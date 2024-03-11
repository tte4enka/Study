using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5task
{
    public interface IEventTrigger
    {
        event EventHandler<TemperatureEventArgs> OnTemperatureChanged;
        int Temperature { set; }
    }
}
