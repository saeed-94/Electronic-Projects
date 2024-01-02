int led =13;
int lm35=A0;
void setup() {
pinMode(led,OUTPUT);
Serial.begin(9600);
}

void loop() { 
  digitalWrite(led,HIGH);
  float temp=analogRead(lm35);
  temp=temp*0.4870;
  Serial.println(double(temp));
  delay(1000);
    
  }
