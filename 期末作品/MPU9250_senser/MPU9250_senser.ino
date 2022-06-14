#include "MPU9250.h"
#include "math.h"
MPU9250 mpu;
float acx,acy,acz,ex,ey,ez;
float x,y,z;
int count = 0;
bool state = false;
float MaxMin[6] = {0,0,0,0,0,0};
float value = 40;
unsigned long myTime;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  Wire.begin();
  mpu.setup(0x68);
  myTime = millis();
  
  delay(1000);

//  mpu.calibrateAccelGyro();
//  mpu.calibrateMag();

}

void loop() {

  
  myTime = millis();
  
  if(mpu.update())
  {

    acx = mpu.getAccX();
    acy = mpu.getAccY();
    acz = mpu.getAccZ();

    ex = mpu.getEulerX();
    ey = mpu.getEulerY();
    ez = mpu.getEulerZ();

    x = atan(acx/sqrt(acy*acy + acz*acz)) * 57.29578;
    y = atan(acy/sqrt(acx*acx + acz*acz)) * 57.29578;
    z = atan(sqrt(acx*acx + acy*acy)/acz) * 57.29578;

    if(x > MaxMin[0])
    {
      MaxMin[0]=x;
    }
    else if(x < MaxMin[3])
    {
      MaxMin[3]=x;
    }
    if(y > MaxMin[1])
    {
      MaxMin[1]=y;
    }
    else if(y < MaxMin[4])
    {
      MaxMin[4]=y;
    }
    if(z > MaxMin[2])
    {
      MaxMin[2]=z;
    }
    else if(z < MaxMin[5])
    {
      MaxMin[5]=z;
    }
    
    if(myTime%300 ==0)
    {
      memset(MaxMin, '0', 6);
      Serial.println(MaxMin[0]);
      state = false;
    }

    if(MaxMin[0]-MaxMin[3] >= 80 && state == false)
    {
      count++;
      Serial.print("第");
      Serial.print(count);
      Serial.println("步");
      state = true;
    }
    else if(MaxMin[1]-MaxMin[4] >= 80 && state == false)
    {
      count++;
      Serial.print("第");
      Serial.print(count);
      Serial.println("步");
      state = true;
    }
    else if(MaxMin[2]-MaxMin[5] >= 80 && state == false)
    {
      count++;
      Serial.print("第");
      Serial.print(count);
      Serial.println("步");
      state = true;
    }
//    Serial.print(MaxMin[0]-MaxMin[3]);Serial.print(", ");
//    Serial.print(MaxMin[1]-MaxMin[4]);Serial.print(", ");
//    Serial.println(MaxMin[2]-MaxMin[5]);
    
//    Serial.print(x); Serial.print(", ");
//    Serial.print(y); Serial.print(", ");
//    Serial.println(z);



  }
  
  /*if ((millis()-prev_ms)>16) {

    mpu.update();
    
    Serial.print(mpu.getEulerX()); Serial.print(", ");
    Serial.print(mpu.getEulerY()); Serial.print(", ");
    Serial.println(mpu.getEulerZ());

    prev_ms = millis();
  }*/
}

void math_cul()
{
  
}
