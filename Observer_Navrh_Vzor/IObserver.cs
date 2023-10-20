using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Navrh_Vzor
{
    internal interface IObserver
    {
        void Update(float temperature, float humidity);
    }
}
