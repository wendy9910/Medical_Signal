#define LED 13
boolean led_state = LOW;
unsigned char counter;
unsigned long temp[3];
unsigned long sub,hr;
bool data_effect = true;
unsigned int heart_rate;
const int max_heartpluse_duty=2000;


void setup() 
{
  // put your setup code here, to run once:
  pinMode(LED,OUTPUT);
  Serial.begin(9600);
  //Serial.println("Please ready your device.");
  delay(1000);
  arrayInit();
  //Serial.println("Heart rate test begin.");
  attachInterrupt(0,interrupt,RISING);

}

void loop() 
{
  // put your main code here, to run repeatedly:
  digitalWrite(LED,led_state);
}

void sum()
{
  if(data_effect)
  {
    heart_rate=120000/(temp[2]-temp[0]);//60*5*1000/20_total_time
    //Serial.print("Heart_rate_is:\t");
    Serial.println(heart_rate); 
  } 
  data_effect=1;//sign bit 
}
void interrupt()
{ // Interrupt service routine. Get the signal from the external interrupt
  //中斷服務程序。 從外部中斷獲取信號

  temp[counter]=millis();

  //Serial.println(counter,DEC);
  //Serial.println(temp[counter]);
  switch(counter)
  {
    case 0:
      sub=temp[counter]-temp[2];
      //Serial.println(sub);
      break;
    default:
      sub=temp[counter]-temp[counter-1];
      //Serial.println(sub);
      break;
  }
  if(sub>max_heartpluse_duty)//set 2 seconds as max heart plus duty(最大心律)
  {
    data_effect=0;//sign bit
    counter=0;
    //Serial.println("Heart rate measure error, test will restart!" );
    arrayInit();
  }
  if (counter==2 && data_effect)
  {
    counter=0;
    sum();
  }
  else if(counter!=2 && data_effect)
    counter++;
  else
  {
    counter=0;
    data_effect=1;
  }
  
}
void arrayInit()
{// Initialization for the array(temp)
  for(unsigned char i=0;i < 2;i ++)
    temp[i]=0;
  temp[2]=millis();
}
