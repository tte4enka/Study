using System;

namespace _5task
{
    public class Thermometer : IEventTrigger
    {
        private int maxTemperature;
        public Thermometer(int maxTemperature)
        {
            this.maxTemperature = maxTemperature;
        }
        public event EventHandler<TemperatureEventArgs> OnTemperatureChanged = delegate { };
        public int Temperature
        {
            set
            {
                var temperature = value;
                if (temperature > maxTemperature)
                {
                    var temperatureValue = new TemperatureEventArgs
                    {
                        Value = temperature,
                    };
                    OnTemperatureChanged(this, temperatureValue);
                }
            }
        }
    }
}
