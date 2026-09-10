using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public CurrentConditionDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            float a = 17.27F;
            float b = 237.7F;
            float A = (float) (a * temperature / (b + temperature) + Math.Log(humidity / 100));
            float Td = (float) (b * A) / (a - A);
            float spread = temperature - Td;
            
            int rainChance;
            if (spread <= 0.5F) {
                rainChance = 95;
            } else if (spread > 0.5F && spread <= 3.0F) {
                rainChance = (int)(90 - ((spread - 0.5F) * 12)); 
            } else if (spread > 3.0F && spread <= 7.0F) {
                rainChance = (int)(59 - ((spread - 3.0F) * 10));
            } else if (spread > 7.0F && spread <= 12.0F) {
                rainChance = (int)(19 - ((spread - 7.0F) * 3.6F));
            } else {
                rainChance = 0;
            }

            Console.WriteLine($"Current Conditions: {Math.Clamp(rainChance, 0, 100)}% of rain");
        }
    }
}
