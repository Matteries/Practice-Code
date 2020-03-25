using System.Collections.Generic;
using Observer_Pattern.Weather_Elements.Interfaces;

namespace Observer_Pattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observerEntry)
        {
            _observers.Add(observerEntry);
        }

        public void RemoveObserver(IObserver observerEntry)
        {
            _observers.Remove(observerEntry);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }
    }
}