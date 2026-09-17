using ObserverPattern.Interfaces;
using ObserverPattern.util;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Display
    {
        private List<float> tempHistory = new List<float>();
        private List<float> tdHistory = new List<float>();
        
        public ForecastDisplay(Subject weatherData) : base(weatherData)
        { 
        }

        public override void Print()
        {
            float Td = DewPoint.GetDewPoint(temperature, humidity); 
            
            tempHistory.Add(temperature);
            tdHistory.Add(Td);

            if (tdHistory.Count < 2)
            {
                Console.WriteLine("Not enough info for a forecast");
                return;
            }

            float spread = temperature - Td;
            
            float totalChange = 0f;
            for (int i = 1; i < tdHistory.Count; i++)
            {
                totalChange += (tdHistory[i] - tdHistory[i - 1]);
            }

            Console.WriteLine($"Forecast: There will be a {Math.Clamp(Math.Round(100f - (spread * 8f) + totalChange / (tdHistory.Count - 1) * 20f), 0, 100)}% chance of rain");
        }
    }
}
