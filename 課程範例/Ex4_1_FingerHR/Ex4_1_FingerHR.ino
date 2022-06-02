#include <Wire.h> 
byte hr; 
void setup() { 
 Serial.begin(9600); 
 Serial.println("heart rate sensor:"); 
 Wire.begin(); 
} 
void loop() { 
 Wire.requestFrom(0xA0 >> 1, 1); // request 1 bytes from slave device 
 if(Wire.available()) { // slave may send less than requested 
 hr = Wire.read(); // receive heart rate value (a byte) 
 Serial.println(hr); // print heart rate value
 } 
 delay(1000); 
} 
