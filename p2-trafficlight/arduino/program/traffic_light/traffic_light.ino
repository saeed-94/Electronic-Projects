const int red =  11;
const int yellow =  12;
const int green =  13;
void setup() {
pinMode(red, OUTPUT);
pinMode(yellow, OUTPUT);
pinMode(green, OUTPUT);
}

void loop() {
digitalWrite(red, LOW);
digitalWrite(yellow, LOW);
digitalWrite(green, HIGH);
delay(6000); 
digitalWrite(red, LOW);
digitalWrite(yellow, HIGH);
digitalWrite(green, LOW);
delay(2000); 
digitalWrite(red, HIGH);
digitalWrite(yellow, LOW);
digitalWrite(green, LOW);
delay(6000); 
}
