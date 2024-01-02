int led=13;
void setup() {
pinMode(led,OUTPUT);
Serial.begin(9600);
}

void loop() {
if(Serial.available())
{
int readserial=Serial.parseInt();
if(readserial==0)
digitalWrite(led,LOW);
if(readserial==1)
digitalWrite(led,HIGH);
}
}
