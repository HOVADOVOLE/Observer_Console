using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Navrh_Vzor
{
    internal class WeatherStation
    {
        float temperature, humidity;
        List<IObserver> observers = new List<IObserver>();

        void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }
        public void SetMeasurements(float temperature, float humidity) {
            this.temperature = temperature;
            this.humidity = humidity;
            Notify();
        } 
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        
    }
}
