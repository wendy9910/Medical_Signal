#include <Arduino.h>
#include <U8g2lib.h>
#ifdef U8X8_HAVE_HW_I2C
#include <Wire.h>
#endif
#include "myFont.h"

U8G2_SSD1306_128X64_NONAME_F_SW_I2C u8g2(U8G2_R0, SCL, SDA, U8X8_PIN_NONE);
float temp;
int humd;
char bufT[30],bufH[20], buf[10];


void setup() {
  Serial.begin(9600);
  u8g2.begin();
  u8g2.setFont(myFont);
  u8g2.enableUTF8Print();// 啟用顯示 UTF-8 編碼字串
  u8g2.setFontDirection(0);
  temp=15.5;
  humd=70;
  Serial.print("°度溫濕心律血氧\n");

}

void loop() {
  temp=15.5f+random(-50, 50)/100.f;
  //sprintf(bufT,"溫度: %.1f°C",temp); //Fail: Got 溫度: ?°C
  dtostrf(temp, 4,1, buf);
  sprintf(bufT,"溫度: %s°C",buf);
  Serial.print(bufT);
  Serial.print("\n");
  humd=70+random(-25, 25);
  sprintf(bufH,"濕度: %3d %%", humd);
  Serial.print(bufH);
  Serial.print("\n");
  u8g2.firstPage();
  do {
    u8g2.setCursor(5,25);
    u8g2.print(bufT);
    u8g2.setCursor(5,45);
    u8g2.print(bufH);
  }while(u8g2.nextPage());
  delay(1000);
}
