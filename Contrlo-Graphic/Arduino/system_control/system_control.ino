void setup() {
pinMode(13,OUTPUT);
Serial.begin(9600);
}

void loop() {
if (Serial.available()){
  char val = Serial.read();
  if (val=='1')
  digitalWrite(13,HIGH);
  if (val=='0')
  digitalWrite(13,LOW);
}
}
