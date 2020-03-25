namespace Observer_Pattern.Weather_Elements.Interfaces
{
    public interface IObserver
    {
        void Update(double temperature, double humidity, double pressure);
    }
}