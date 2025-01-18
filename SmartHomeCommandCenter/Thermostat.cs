using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeCommandCenter
{
    internal class Thermostat
    {
        public void SetTemperature(int temperature) => Console.WriteLine($"Temperature set to {temperature}");
        public void SetDefault() => Console.WriteLine($"Temperature set to 23oC");
    }
}
