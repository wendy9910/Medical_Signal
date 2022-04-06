#include <OneWire.h>
#include <DallasTemperature.h>

float myTemp;
float myHighTemp;
float myLowTemp = 50;


#define ONE_WIRE_BUS 2

OneWire oneWire(ONE_WIRE_BUS);
DallasTemperature sensors(&oneWire);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("Dallas Temperature IC Control Library Demo");
  sensors.begin();// Start the OneWire library

}

void loop() {
  // put your main code here, to run repeatedly:
  readtemp();// Read the temperature
  // Write the Results to the serial Monitor
  serialPrint();

}


void readtemp()
{
  // call sensors.requestTemperatures() to issue a global temperature
  // request to all devices on the bus\
  //Send the command to get temperatures
  sensors.requestTemperatures();
  myTemp = (sensors.getTempCByIndex(0));
  // Set High or Low Temp
  if (myTemp < myLowTemp)
    myLowTemp = myTemp;
  else if (myTemp > myHighTemp)
    myHighTemp = myTemp;
}

void serialPrint()
{
  Serial.print("Current Temp: ");
  Serial.print(myTemp);
  Serial.print("C");
  Serial.print(" Lowest Temp: ");
  Serial.print(myLowTemp);
  Serial.print("C");
  Serial.print(" Highest Temp: ");
  Serial.print(myHighTemp);
  Serial.println("C");
  delay (500);
  Serial.print(DallasTemperature::toFahrenheit(myTemp));
  Serial.print("F / ");
  Serial.print(DallasTemperature::toFahrenheit(myLowTemp));
  Serial.print("F / ");
  Serial.print(DallasTemperature::toFahrenheit(myHighTemp));
  Serial.println("F ");
  Serial.println();
  delay (500);
}
