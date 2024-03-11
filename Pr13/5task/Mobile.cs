using System;

namespace _5task
{
    public class Mobile : IEventTrigger
    {
        private int maxTemperature;
        public Mobile(int maxTemperature)
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
