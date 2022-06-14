#include "MPU9250.h"
#include "math.h"
float acx,acy,acz;
MPU9250 mpu;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  Wire.begin();
  mpu.setup(0x68);
  delay(1000);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(mpu.update())
  {

    acx = mpu.getAccX();
    acy = mpu.getAccY();
    acz = mpu.getAccZ();

    Serial.print(acx); Serial.print(", ");
    Serial.print(acy); Serial.print(", ");
    Serial.println(acz);

  }

}
