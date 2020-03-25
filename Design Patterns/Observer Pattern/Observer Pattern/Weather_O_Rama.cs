using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Weather_O_Rama
    {
        public Weather_O_Rama()
        {
            float temprature = getTemperature();
            float humidity = getHumidity();
            float pressure = getPressure();

            currentConditionsDisplay.update(temprature, humidity, pressure);
            statisticsDisplay.update(temprature, humidity, pressure);
        }
    }
}