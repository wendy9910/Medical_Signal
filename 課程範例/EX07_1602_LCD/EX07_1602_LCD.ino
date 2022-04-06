#include <LiquidCrystal_PCF8574.h>
#include <dht.h>

dht DHT;
#define DHT11_PIN 7

LiquidCrystal_PCF8574 lcd(0x27);  // 設定i2c位址，一般情況就是0x27和0x3F兩種

void setup() {
  Serial.begin(9600);
  lcd.begin(16, 2); //初始化 LCD，一行 16 的字元，共 2 行，預設開啟背光 
  lcd.setBacklight(255);
  lcd.clear();
  lcd.setCursor(0, 0);  //設定游標位置 (字,行)
  lcd.print("Get");
  lcd.setCursor(4, 0);
  lcd.print("Temp:");
  lcd.setCursor(11, 0);
  lcd.print("Humi:");
  delay(1000);//Wait before accessing Sensor
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

  lcd.setCursor(4, 1);
  lcd.print(DHT.temperature, 1);
  lcd.setCursor(11, 1);
  lcd.print(DHT.humidity, 1);
  delay(2000);
}
