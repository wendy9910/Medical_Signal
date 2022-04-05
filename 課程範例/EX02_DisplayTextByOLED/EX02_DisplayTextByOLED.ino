#include <Arduino.h>
#include <U8g2lib.h>
#ifdef U8X8_HAVE_HW_I2C
#include <Wire.h>
#endif
// Please UNCOMMENT one of the contructor lines below
U8G2_SSD1306_128X64_NONAME_F_SW_I2C u8g2(U8G2_R0, /* clock=*/ SCL, /* data=*/ SDA, /* reset=*/ U8X8_PIN_NONE);
// All Boards without Reset of the Display
// End of constructor list
String s0,s1;
void setup()
{ 
  u8g2.begin();
  u8g2.enableUTF8Print();//enable UTF8 support for the Arduino print() function
  //u8g2.setFont(u8g2_font_unifont_t_chinese2); // use chinese2 for all the glyphs of "你好世界"
  //u8g2.setFont(u8g2_font_ncenB10_tr);
  u8g2.setFont(u8g2_font_7x13B_tf);
  u8g2.setFontDirection(0);
}
void loop()
{ 
  u8g2.clearBuffer();
  u8g2.setCursor(0, 15);
  u8g2.print("Hello World!!");
  u8g2.sendBuffer();
  delay(3000);
}
