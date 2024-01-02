import controlP5.*; // 
import processing.serial.*;
Serial port;
ControlP5 cp5;
PFont font;
void setup()
{
 size(300, 450);    
  printArray(Serial.list());   
  port = new Serial(this, "COM1", 9600);
  cp5 =new ControlP5(this);
  font= createFont("Calibri light bold",20);
  cp5.addButton("ON")
  .setPosition(100,50)
  .setSize(100,80)
  .setFont(font);
  cp5 =new ControlP5(this);
  cp5.addButton("OFF")
  .setPosition(100,250)
  .setSize(100,80)
  .setFont(font);

}
void draw()
{
  background(150,0,150);
   fill(0, 255, 0);   //text color (r, g, b)
   textFont(font);
    text("LED CONTROL", 75, 30);  // ("text", x coordinate, y coordinat)
}
void ON ()
{
  port.write('1');
}
void OFF ()
{
  port.write('0');
}
