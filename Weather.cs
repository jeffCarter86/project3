using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions;
        public string predictedForecast;
        Random random;
        public Weather()
        {
            random = new Random();
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Hazy", "Rain" };
            SetTemperature();
            SetCondition(GenerateRandomIndex());
            SetForecast();
        }

        public void SetTemperature()
        {
                  
            temperature = random.Next(50, 101);
        }
        public void SetCondition(int index)
        {
            
            condition = weatherConditions[index];
        }
        public void SetForecast()
        {
            
            int temperatureVariance = random.Next(-7, 8);
            predictedForecast = (temperature + temperatureVariance) + " degrees and " + condition;
        }
        public int GenerateRandomIndex()
        {
            return random.Next(weatherConditions.Count);
        }


    }
}
