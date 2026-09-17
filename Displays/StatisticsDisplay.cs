using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Display
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        
        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        { 
        }
        
        public new void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            if (minTemp > temperature || minTemp == 0) minTemp = temperature;
            if (maxTemp < temperature) maxTemp = temperature;
            sumTemperature += temperature;
            countUpdated++;
            Print();
        }

        public override void Print()
        {
            Console.WriteLine($"Temp: Avg temp {sumTemperature / countUpdated}°c ({minTemp} - {maxTemp}");
        }
    }
}
