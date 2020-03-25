using System;
using Observer_Pattern.Weather_Elements.Interfaces;

namespace Observer_Pattern.Weather_Elements
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }
    }
}