using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.util;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Display
    {
        public CurrentConditionDisplay(Subject weatherData) :  base(weatherData)
        { 
        }

        public override void Print()
        {
            float spread = temperature - DewPoint.GetDewPoint(temperature, humidity);
            
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
