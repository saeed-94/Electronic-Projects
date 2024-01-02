int red=3;
int green=5;
int blue=6;
void setup() {
pinMode(red,OUTPUT);
pinMode(green,OUTPUT);
pinMode(blue,OUTPUT);
Serial.begin(9600);
}

void loop() {
  while (Serial.available())
  {
    int RedPwr=Serial.parseInt();
    int GreenPwr=Serial.parseInt();
    int BluePwr=Serial.parseInt();
    analogWrite(red,RedPwr);
    analogWrite(green,GreenPwr);
    analogWrite(blue,BluePwr);
    Serial.print(RedPwr);
    Serial.print(",");
    Serial.print(GreenPwr);
    Serial.print(",");
    Serial.print(BluePwr);
    Serial.println(",");
  }
delay(1000);

}
