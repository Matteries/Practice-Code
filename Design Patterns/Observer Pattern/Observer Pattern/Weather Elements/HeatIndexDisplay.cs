using System;
using Observer_Pattern.Weather_Elements.Interfaces;

namespace Observer_Pattern.Weather_Elements
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private double _heatIndex;

        public HeatIndexDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Heat Index is {0}", _heatIndex);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _heatIndex = ComputeHeatIndex(temperature, humidity);

            Display();
        }

        private double ComputeHeatIndex(double temperature, double relativeHumidity)
        {
            double heatIndex = ((16.923 + (0.185212 * temperature) + (5.37941 * relativeHumidity) - (0.100254 * temperature * relativeHumidity) +
                          (0.00941695 * (temperature * temperature)) + (0.00728898 * (relativeHumidity * relativeHumidity)) +
                          (0.000345372 * (temperature * temperature * relativeHumidity)) - (0.000814971 * (temperature * relativeHumidity * relativeHumidity)) +
                          (0.0000102102 * (temperature * temperature * relativeHumidity * relativeHumidity)) - (0.000038646 * (temperature * temperature * temperature)) + 
                          (0.0000291583 * (relativeHumidity * relativeHumidity * relativeHumidity)) + (0.00000142721 * 
                          (temperature * temperature * temperature * relativeHumidity)) +
                          (0.000000197483 * (temperature * relativeHumidity * relativeHumidity * relativeHumidity)) - (0.0000000218429 * 
                          (temperature * temperature * temperature * relativeHumidity * relativeHumidity)) + 0.000000000843296 * 
                          (temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)) -
                          (0.0000000000481975 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)));

            return heatIndex;
        }
    }
}