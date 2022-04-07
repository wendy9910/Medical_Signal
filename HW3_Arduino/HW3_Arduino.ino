const byte LEDpin=13;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("Hello!");
  Serial.println("Type 1 to Enable LED every one-sec");
  Serial.println("Type 0 to Turn OFF LED");
  Serial.println("Type 500~5000 to see duration for LED ON");
  pinMode(LEDpin,OUTPUT);
}
char val=0;
String numberStr;
int i0=0,i=0,tDuration=1000;

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available())
  {
    numberStr=Serial.readString();
  }
  if(numberStr.toInt()==1)
  {
    digitalWrite(LEDpin,HIGH);
    Serial.print("LED: ON duration (");
    Serial.print(tDuration);
    Serial.print("ms),\t");
    delay(tDuration);
    digitalWrite(LEDpin,LOW);
    Serial.print("LED: OFF");
    Serial.println("- - - - - - - -");  
  }
  else if(numberStr.toInt()==0)
  {
    digitalWrite(LEDpin,LOW);
    Serial.println("LED: OFF");
   }
  else if(numberStr.toInt()>=500 && numberStr.toInt()<= 5000)
  {
    tDuration=numberStr.toInt();
    Serial.print("Set delay time: ");
    Serial.print(tDuration);
    Serial.println("ms");
    numberStr="1";
   }
   delay(tDuration);
  
}
