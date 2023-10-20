using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Navrh_Vzor
{
    internal class Device : IObserver
    {
        string name;
        public Device(string name)
        {
            this.name = name;
        }
        public void Update(float temperature, float humidity)
            {
                Console.WriteLine($"Device {name}: " + temperature + "°C " + humidity + "%.");
            }
        }
    }

