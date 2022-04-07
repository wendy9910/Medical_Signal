#include <Arduino.h>
#include <dht.h>
#include <U8g2lib.h>
#ifdef U8X8_HAVE_HW_I2C
#include <Wire.h>
#endif
#include "myFont.h"

U8G2_SSD1306_128X64_NONAME_F_SW_I2C u8g2(U8G2_R0, /* clock=*/ SCL, /* data=*/ SDA, /* reset=*/ U8X8_PIN_NONE);
dht DHT;
#define DHT11_PIN 7

float temp;
int humi;
char bufT[30],bufH[20], buf[10];

void setup() {
  Serial.begin(9600);
  u8g2.begin();
  u8g2.setFont(myFont);
  u8g2.enableUTF8Print();// 啟用顯示 UTF-8 編碼字串
  u8g2.setFontDirection(0);

}

void loop() {
  // put your main code here, to run repeatedly:
   Serial.print("DHT11, \t");
   int chk = DHT.read11(DHT11_PIN);
   switch (chk)
   {
   case DHTLIB_OK:
     Serial.print("OK,\t");
     // DISPLAY DATA
     Serial.print(DHT.humidity, 1);
     Serial.print(",\t");
     Serial.println(DHT.temperature, 1);
     break;
   case DHTLIB_ERROR_CHECKSUM:
     Serial.print("Checksum error,\t");
     break;
   case DHTLIB_ERROR_TIMEOUT:
     Serial.print("Time out error,\t");
     break;
   case DHTLIB_ERROR_CONNECT:
     Serial.print("Connect error,\t");
     break;
   case DHTLIB_ERROR_ACK_L:
     Serial.print("Ack Low error,\t");
     break;
   case DHTLIB_ERROR_ACK_H:
     Serial.print("Ack High error,\t");
     break;
   default:
     Serial.print("Unknown error,\t");
     break;
   }
   humi = DHT.humidity;
   temp = DHT.temperature;
   
   dtostrf(temp, 4,1, buf);
   sprintf(bufT,"溫度: %s°C",buf);
   Serial.print(bufT);
   Serial.print("\n");

   sprintf(bufH,"濕度: %3d %%", humi);
   Serial.print(bufH);
   Serial.print("\n");  
   u8g2.firstPage();
   
   do {
    u8g2.setCursor(2,25);
    u8g2.print(bufT);
    u8g2.setCursor(2,45);
    u8g2.print(bufH);
  }while(u8g2.nextPage());
  delay(1000);
   
}
