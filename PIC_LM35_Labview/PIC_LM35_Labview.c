#include <16f877a.h> //Micro Name
#device adc=10
#use delay(clock=1000000) // Oscillator Frequency
#fuses Hs,nowdt// Micro is High Ferquency And No watchdog
#define use_portb_lcd true
#include <lcd.c>

void main(){

int temp;
float temp2;
setup_adc(ADC_CLOCK_INTERNAL);
lcd_init();


while(true){
lcd_putc("temperature=");
set_adc_channel(0);
delay_us(10);
temp=read_adc();
printf(lcd_putc, "%d",temp);
}
}




