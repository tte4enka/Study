using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _5task
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            IEventTrigger trigger = new Thermometer(30);
            trigger.OnTemperatureChanged += (o, e) => Console.WriteLine($"Temperature is changed to {e.Value} °C. {((o is Mobile) ? "Triggered manually by mobile." : "Triggered automatically by the thermometer.")}");
            trigger.OnTemperatureChanged += (o, e) => Console.WriteLine("1. Приезжает грузовик с мороженым!");
            trigger.OnTemperatureChanged += (o, e) => Console.WriteLine("2. Включается кондиционер.");
            trigger.OnTemperatureChanged += (o, e) => Console.WriteLine("3. Закрываются все окна и двери.");
            trigger.Temperature = 32; 
            Console.ReadKey();
        }
    }
}
