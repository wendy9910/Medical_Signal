#include <Wire.h>
#include "MAX30100_PulseOximeter.h"
#include <Arduino.h>
#include <U8x8lib.h>//Comes from U8g2
#ifdef U8X8_HAVE_HW_SPI
#include <SPI.h>
#endif
#define REPORTING_PERIOD_MS     1000
U8X8_SH1106_128X64_NONAME_HW_I2C u8x8(/* reset=*/ U8X8_PIN_NONE);
PulseOximeter pox;
uint32_t tsLastReport = 0;

void onBeatDetected() {
  // put your setup code here, to run once:
  Serial.println("Beat!");
}

void setup() {
  // put your main code here, to run repeatedly:
  Serial.begin(115200);
  u8x8.begin();
  u8x8.setPowerSave(0);
  u8x8.clearDisplay();
  //u8x8.setFont(u8x8_font_chroma48medium8_r);//small font
  u8x8.setFont(u8x8_font_7x14B_1x2_f);
  //u8x8.setFont(u8x8_font_courB18_2x3_f);//disturbs SPO2 calculating
  Serial.print("Initializing pulse oximeter..");       
  if (!pox.begin()) {
    Serial.println("FAILED");
    u8x8.drawString(0,0,"SPO2 ");
    u8x8.drawString(1,1,"Sensor Fail!");
    delay(2000);
    for(;;);
  }
  else {
    Serial.println("SUCCESS");
  }
   
  pox.setIRLedCurrent(MAX30100_LED_CURR_7_6MA);//Must have this statement
  // Register a callback for the beat detection
  pox.setOnBeatDetectedCallback(onBeatDetected);
}
int hr,spo2,i=0;
void loop()
{
   pox.update();
  // For both, a value of 0 means "invalid"
   if (millis()-tsLastReport > REPORTING_PERIOD_MS) {
      hr=(int)(pox.getHeartRate()+0.5);
      spo2=pox.getSpO2();
      if ((spo2 <=100 && spo2 >= 90) || i<10)
      {
        Serial.print("Heart rate:");
        Serial.print(hr);
        Serial.print("bpm / SpO2:");
        Serial.print(spo2);
        Serial.println("%");
         
        u8x8.clearDisplay();  
        u8x8.drawString(0,0,"Heart Rate:");
        u8x8.setCursor(11,0);
        u8x8.print(hr);
        u8x8.drawString(13,0,"bpm");
        u8x8.drawString(0,3,"SpO2: ");
        u8x8.setCursor(6,3);
        u8x8.print(spo2);
        u8x8.drawString(8,3,"%");          
      }
      i++;
      tsLastReport = millis();
  }
 
}
