int led =13;
int lm35=A0;
void setup() {
pinMode(led,OUTPUT);
Serial.begin(9600);
}

void loop() {
if (Serial.available())
{
  int readserial=Serial.parseInt();
  if(readserial==1)
  {
    digitalWrite(led,HIGH);
  float temp=analogRead(lm35);
  temp=temp*0.4870;
  Serial.println(temp);
  }
  if(readserial==0)
  {
    digitalWrite(led,LOW);
  }
}
}
