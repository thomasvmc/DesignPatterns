using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
        }
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            if (minTemp > temperature || minTemp == 0) minTemp = temperature;
            if (maxTemp < temperature) maxTemp = temperature;
            sumTemperature += temperature;
            countUpdated++;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Temp " + sumTemperature / countUpdated + "°c (" + minTemp + " - " + maxTemp + ")");
        }
    }
}
