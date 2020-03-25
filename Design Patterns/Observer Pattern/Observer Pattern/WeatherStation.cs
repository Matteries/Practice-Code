using System;
using Observer_Pattern.Weather_Elements;

namespace Observer_Pattern
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4d);
            weatherData.SetMeasurements(82, 70, 29.2d);
            weatherData.SetMeasurements(78, 90, 29.2d);
        }
    }
}