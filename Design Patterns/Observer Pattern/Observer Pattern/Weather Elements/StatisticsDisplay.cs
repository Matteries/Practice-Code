using System;
using Observer_Pattern.Weather_Elements.Interfaces;

namespace Observer_Pattern.Weather_Elements
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Average/Minimum/Maximum temperature is {0}/{1}/{2}", _temperature - 1, _temperature, _temperature + 1);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }
    }
}