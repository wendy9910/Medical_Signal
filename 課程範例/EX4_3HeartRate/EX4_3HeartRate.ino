#include <Wire.h>
#include "MAX30100_PulseOximeter.h"
/* MAX30100_PulseOximeter.h"找到多個程式庫
已使用: F:\MCU_Demos\MCU_HealthSignal\111\libraries\MAX30100_milan
未使用: F:\MCU_Demos\MCU_HealthSignal\111\libraries\Arduino‐MAX30100*/
#define REPORTING_PERIOD_MS     1000
  
PulseOximeter pox;
uint32_t tsLastReport = 0;

void setup() {
  
  Serial.begin(115200);
  Serial.print("Initializing pulse oximeter…");
  
  if (!pox.begin()) {
    Serial.println("FAILED");
    for(;;);
  } 
  else {
    Serial.println("SUCCESS");
  }
  
  pox.setIRLedCurrent(MAX30100_LED_CURR_7_6MA);
  pox.setOnBeatDetectedCallback(onBeatDetected);
}

char bufHR[30],bufSpO2[20];
int hr,spo2;

void loop() {
 // Make sure to call update as fast as possible
    pox.update();
    if (millis()- tsLastReport > REPORTING_PERIOD_MS) {
      hr=(int)pox.getHeartRate();
      spo2=pox.getSpO2();
      if (spo2 >100)
        spo2=100;
      sprintf(bufHR,"HR: %d bpm",hr);
      Serial.print(bufHR);
      Serial.print(", ");
      sprintf(bufSpO2,"SpO2: %d %%",spo2);
      Serial.print(bufSpO2);
      Serial.print("\n");
      tsLastReport = millis();
    }

}

void onBeatDetected()
{
    Serial.println("Beat!");
}
