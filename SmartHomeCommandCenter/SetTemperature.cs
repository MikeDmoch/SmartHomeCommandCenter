using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeCommandCenter
{
    internal class SetTemperature : ICommand
    {
        private readonly Thermostat thermostat;
        private readonly int temperature;

        public SetTemperature(Thermostat therm, int temp)
        {
            thermostat = therm;
            temperature = temp;
        }
        public void Execute() => thermostat.SetTemperature(temperature);

        public void Undo() => thermostat.SetDefault();
    }
}
