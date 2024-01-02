#include "DHT.h"
#define DHTPIN 2    
int led1=13;
int led2=12;
int led3=11;
#define DHTTYPE DHT11   // DHT 11
//#define DHTTYPE DHT22   // DHT 22  (AM2302), AM2321
//#define DHTTYPE DHT21   // DHT 21 (AM2301)
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
  pinMode(led3,OUTPUT);
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  delay(2000);
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  if (isnan(h) || isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }
  float hic = dht.computeHeatIndex(t, h, false);
if (Serial.available())
{
  int readserial=Serial.parseInt();
 if(readserial==1)
{
 digitalWrite(led1,HIGH);
 Serial.println(String(t));
}
if(readserial==2)
{
   digitalWrite(led2,HIGH);
  Serial.println(String(h));
}
if(readserial==3)
{
  digitalWrite(led3,HIGH);
  Serial.println(String(hic));
}
}
}
