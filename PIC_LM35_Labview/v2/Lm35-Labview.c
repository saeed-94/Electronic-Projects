#include <Lm35-Labview.h>
#define LCD_ENABLE_PIN PIN_B0
#define LCD_RS_PIN PIN_B1
#define LCD_RW_PIN PIN_B2
#define LCD_DATA4 PIN_B4
#define LCD_DATA5 PIN_B5
#define LCD_DATA6 PIN_B6
#define LCD_DATA7 PIN_B7

#include <lcd.c>

void main()
{
float temp;
   setup_adc_ports(AN0);
   setup_adc(ADC_CLOCK_INTERNAL);

   lcd_init();
   delay_ms(1000);
while(True)
   {
set_adc_channel(0);

delay_us(10);
temp=read_adc();
temp=temp*0.486;
      
     printf("%f",temp);
     printf("\n");
     delay_ms(500);
     lcd_putc("\f");
      if(temp<15)
      { 
         OUTPUT_C(0x01);
         delay_ms(100);
         lcd_putc("\fTemp is Low");
      }
      if(temp>=15 && temp<30)
      {
         OUTPUT_C(0x02);
         delay_ms(100);
         lcd_putc("\fTemp is Normal");
      }
      if(temp>=30)
      {
         OUTPUT_C(0x04);
         delay_ms(100);
         lcd_putc("\fTemp is HIGH");
      }
    
   }
   }
//}

