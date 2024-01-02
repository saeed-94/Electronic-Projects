      //import controlP5.*; 
      import processing.serial.*;
      import meter.*;
      Meter g1;
      Meter g2;
      //Meter g3;
      Serial port;
     //ControlP5 cp5;
      //PFont font;
      //PFont font1;
      //int val;
      void setup()
      {
       size(950, 400);  
       background(100,100,170);
        port = new Serial(this, "COM10", 9600);
        //cp5 =new ControlP5(this);
        //font= createFont("calibri bold",28);
        //font= createFont("Arial bold",15);
        //cp5.addButton("ON")
        //.setPosition(450,50)
        //.setSize(100,80)
        //.setFont(font);
        //cp5 =new ControlP5(this);
        //cp5.addButton("OFF")
        //.setPosition(600,50)
        //.setSize(100,80)
        //.setFont(font);
        g1=new Meter(this,20,80);
        g1.setTitleFontSize(26);
        g1.setTitleFontName("Arial bold");
        g1.setTitle("Temperture: C");
        String[] scaleLabels = {"0","10","20","30","40","50","60","70","80",};
        g1.setScaleLabels(scaleLabels);
        g1.setScaleFontSize(20);
        g1.setScaleFontName("Arial bold");
        g1.setScaleFontColor(color(150,90,150));
        g1.setDisplayDigitalMeterValue(true);
        g1.setArcColor(color(180,100,80));
        g1.setArcThickness(12); 
        g1.setMaxScaleValue(80);
        g1.setMinInputSignal(0);
        g1.setMaxInputSignal(80);
        g1.setNeedleThickness(4);
        
        g2=new Meter(this,480,80);
        g2.setTitleFontSize(26);
        g2.setTitleFontName("Arial bold");
        g2.setTitle("Humidity:%");
        String[] scaleLabels2 = {"0","10","20","30","40","50","60","70","80","90","100"};
        g2.setScaleLabels(scaleLabels2);
        g2.setScaleFontSize(20);
        g2.setScaleFontName("Arial bold");
        g2.setScaleFontColor(color(150,90,150));
        g2.setDisplayDigitalMeterValue(true);
        g2.setArcColor(color(180,100,80));
        g2.setArcThickness(12); 
        g2.setMaxScaleValue(100);
        g2.setMinInputSignal(0);
        g2.setMaxInputSignal(100);
        g2.setNeedleThickness(4);
        
        //g3=new Meter(this,600,480);
        //g3.setTitleFontSize(26);
        //g3.setTitleFontName("Times new Roman bold");
        //g3.setTitle("Heat Index: C ");
        //String[] scaleLabels3 = {"0","10","20","30","40","50","60","70","80","90","100","110","120","130","140","150","160","170","180"};
        //g3.setScaleLabels(scaleLabels3);
        //g3.setScaleFontSize(20);
        //g3.setScaleFontName("Arial bold");
        //g3.setScaleFontColor(color(150,90,150));
        //g3.setDisplayDigitalMeterValue(true);
        //g3.setArcColor(color(180,100,80));
        //g3.setArcThickness(12); 
        //g3.setMaxScaleValue(90);
        //g3.setMinInputSignal(0);
        //g3.setMaxInputSignal(90);
        //g3.setNeedleThickness(4);
  }
      void draw()
  {
         textSize(30);
                  fill(255, 0, 0);   //text color (r, g, b)

          text("DHT22", 390, 40);  // ("text", x coordinate, y coordinat)
          if ( port.available() > 0) {  // If data is available,
          String val = port.readString();         // read it and store it in val
          String[] list = split(val, ',');
          float temp = float(list[0]);
          float hum = float(list[1]);
          //float hic = float(list[2]);
          g1.updateMeter(int(temp));
          g2.updateMeter(int(hum));
          //g3.updateMeter(int(hic));
         println( "Temperature:" + temp + "'C" + "Humidity: "+ hum + "%");
     }
    }
     // void ON ()
     // {
     //     //port.write('1');
     //    if ( port.available() > 0) {  // If data is available,
     //     String val = port.readString();         // read it and store it in val
     //     String[] list = split(val, ',');
     //     float hum = float(list[0]);
     //     float temp = float(list[1]);
     //     float hic = float(list[2]);
     //     g1.updateMeter(int(hum));
     //     g2.updateMeter(int(temp));
     //     g3.updateMeter(int(hic));
     //    println("Humidity: "+ hum + " " + "Temperature:" + temp + " " + "Hit Index:" + hic);
     //}    
        
     // }
     // void OFF ()
     // {
     //  // port.write('0');
     // }
      
   
