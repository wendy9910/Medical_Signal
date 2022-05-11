#include <TimerOne.h>
#include <SoftwareSerial.h>

SoftwareSerial BT(10, 11); 
const byte LEDpin=13;
const int sampling=250, freq=10;
byte data;
float y;

void setup() {
  Serial.begin(9600);
  for (int i=0;i<5;i++)
  {
    digitalWrite(LEDpin,HIGH);
    delay(1000);
    digitalWrite(LEDpin,LOW); 
  }
  Serial.println("Serial is ready!");
  BT.println("BT is ready!");
  BT.begin(38400); // HC-05 default speed in AT command
  // initialize timer1, and set a 4ms second period
  Timer1.initialize(4000); 
  Timer1.attachInterrupt(callback);
}
void callback()
{
  y=125*sin(2*3.14159*freq*i++/sampling)+125;//i??
  data=(byte)(y+0.5); 
  //Serial.write(data)
  Serial.println(data);
  BT.println(data);   
}
void loop() {
  
}
