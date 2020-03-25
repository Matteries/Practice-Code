using System;
using Observer_Pattern.Weather_Elements.Interfaces;

namespace Observer_Pattern.Weather_Elements
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
       

        public ForecastDisplay(WeatherData weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }
        public void Display()
        {
            Console.Write("Latest Forecast: ");
            if (HigherPressure())
            {
                Console.WriteLine("The weather is looking a lot brighter!");
            }
            else if (EqualPressure())
            {
                Console.WriteLine("The weather is predicted to be the same");
            }
            else if (LowerPressure())
            {
                Console.WriteLine("Wrap up warm, it might get chilly!");
            }
        }

        private bool HigherPressure()
        {
            return _temperature > 78.0;
        }

        private bool EqualPressure()
        {
            return _temperature <= 78;
        }

        private bool LowerPressure()
        {
            return _temperature > 85;
        }
    }
}