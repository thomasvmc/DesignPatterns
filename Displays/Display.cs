using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal abstract class Display : Observer
    {
        protected float temperature;
        protected float humidity;
        protected Subject weatherData;
        
        public Display(Subject weatherData) 
        { 
            this.weatherData  = weatherData;
            weatherData.RegisterObserver(this);
        }
        
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            Print();
        }

        public abstract void Print();
    }
}