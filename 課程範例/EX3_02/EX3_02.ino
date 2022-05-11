const int sampling=250, freq=10;
int i, data;
float dt;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  i=-1;
  dt=1000.0/sampling;
}

void loop() {
  // put your main code here, to run repeatedly:
  i=(i+1)%sampling;
  data=(int)(125*sin(2*3.14159*freq*i/sampling));
  Serial.println(data);
  delay(dt);

}
