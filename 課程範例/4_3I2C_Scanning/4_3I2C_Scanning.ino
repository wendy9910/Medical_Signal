#include <Wire.h>
#include <U8x8lib.h>//Comes from U8g2
#ifdef U8X8_HAVE_HW_SPI
#include <SPI.h>
#endif
#define REPORTING_PERIOD_MS     1000
U8X8_SH1106_128X64_NONAME_HW_I2C u8x8(/* reset=*/ U8X8_PIN_NONE);

void setup()
{
  Wire.begin(); // Wire communication begin
  Serial.begin(9600); // The baudrate of Serial monitor is set in 9600
  while (!Serial); // Waiting for Serial Monitor
  Serial.println("\nI2C Scanner");

  u8x8.begin();
  u8x8.setPowerSave(0);
  u8x8.clearDisplay();
  u8x8.setFont(u8x8_font_7x14B_1x2_f);
  Serial.print("Initializing pulse oximeter.."); 
  
}
void loop()
{
  byte error, address; //variable for error and I2C address
  int nDevices;
  Serial.println("Scanning...");
  nDevices = 0;
  for (address = 1; address < 127; address++ )
  {
    // The i2c_scanner uses the return value of the Write.endTransmisstion to see if
    // a device did acknowledge to the address.
    Wire.beginTransmission(address);
    error = Wire.endTransmission();
    if (error == 0)
    {
      Serial.print("I2C device found at address");
      if (address < 16)
        Serial.print("0");
      Serial.print(address, HEX);
      Serial.println("  !");
      nDevices++;
      u8x8.clearDisplay();  
      u8x8.drawString(0,0,"I2C device found at address");
      u8x8.drawString(0,3,"0x");
      u8x8.setCursor(2,3);
      u8x8.print(address);
    }
    else if (error == 4)
    {
      Serial.print("Unknown error at address 0x");
      if (address < 16)
        Serial.print("0");
      Serial.println(address, HEX);
      u8x8.clearDisplay();  
      u8x8.drawString(0,0,"Unknown error at address");
      u8x8.drawString(0,3,"0x");
      u8x8.setCursor(2,3);
      u8x8.print(address);
              
    }
  }
  if (nDevices == 0)
  {
    Serial.println("No I2C devices found\n");
    u8x8.drawString(0,6,"No I2C");
  } 
  else
  {
    Serial.println("done\n");
    u8x8.drawString(0,6,"done");
  }
    
  delay(5000); // wait 5 seconds for the next I2C scan
}
