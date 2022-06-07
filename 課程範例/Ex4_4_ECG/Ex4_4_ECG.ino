 
/*Demo Program for AD8232 Heart Rate sensor. https://github.com/sparkfun/AD8232_Heart_Rate_Monitor 
The AD8232 Heart Rate sensor is a low cost EKG/ECG sensor. 
This example shows how to create an ECG with real time display. */ 
void setup() { // initialize the serial communication: 
 Serial.begin(9600); 
 pinMode(10, INPUT); // Setup for leads off detection LO + 10 
 pinMode(11, INPUT); // Setup for leads off detection LO - 11 
} 
void loop() { 
 if((digitalRead(10) != 1)&&(digitalRead(11) != 1)) 
 Serial.println(analogRead(A0)); 
 delay(4); //Wait for a bit to keep serial data from saturating 
}
