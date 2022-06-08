byte data[]={0xFF, 0xFF, 0, 0, 0xFE, 0xFE}; 
int iECG; 
void setup() { // initialize the serial communication: 
 Serial.begin(9600); 
 pinMode(10, INPUT); // Setup for leads off detection LO + 10 
 pinMode(11, INPUT); // Setup for leads off detection LO - 11 
} 
void loop() { 
 if((digitalRead(10) != 1)&&(digitalRead(11) != 1)) 
 { 
 //Serial.println(analogRead(A0)); 
 iECG = analogRead(A0); 
 data[2]=(byte)( iECG &0xFF); //Low byte 
 data[3]=(byte)(( iECG &0x0300)>>8); //Hight byte 
 Serial.write(255); 
 Serial.write(255); 
 Serial.write(data[2]); 
 Serial.write(data[3]); 
 Serial.write(254); 
 Serial.write(254); 
 } 
 delay(4); //Wait for a bit to keep serial data from saturating 
}
