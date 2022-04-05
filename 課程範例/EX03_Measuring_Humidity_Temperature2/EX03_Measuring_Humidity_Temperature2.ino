#include <DHT.h>
#define DHTPIN 7
#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("DHT TEST PROGRAM");
  Serial.print("LIBRARY VERSION: ");
  Serial.println("Type,\tstatus,\tHumidity (%),\tTemperature (C)");
  dht.begin();
  delay(1000);//Wait before accessing Sensor

}

void loop() {
  // put your main code here, to run repeatedly:
   Serial.print("DHT11, \t");
   float h = dht.readHumidity();
   float t = dht.readTemperature();
   float f = dht.readTemperature(true); 

  Serial.print(F("Humidity: "));
  Serial.print(h);
  Serial.print(F("%  Temperature: "));
  Serial.print(t);
  Serial.print(F("°C "));
  Serial.print(f);
   
  delay(2000);


}
