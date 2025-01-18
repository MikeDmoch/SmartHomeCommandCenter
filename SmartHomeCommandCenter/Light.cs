using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeCommandCenter
{
    internal class Light
    {
        public bool lightTurnedOn = false;

        public void Switch()
        {
            lightTurnedOn = !lightTurnedOn;
            if (lightTurnedOn)
            {
                Console.WriteLine("Light turned off");
            }
            else Console.WriteLine("Light turned on");
        }
    }
}
