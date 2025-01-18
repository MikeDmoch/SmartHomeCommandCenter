using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeCommandCenter
{
    internal class SwitchLight : ICommand
    {
        private readonly Light light;

        public SwitchLight(Light l)
        {
            light = l;
        }

        public void Execute() => light.Switch();

        public void Undo() => light.Switch();
    }
}
