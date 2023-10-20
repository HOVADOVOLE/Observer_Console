using Observer_Navrh_Vzor;

class Program
{
    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();
        Device device = new Device("1");
        Device device2 = new Device("2");
        weatherStation.AddObserver(device);
        weatherStation.AddObserver(device2);
        weatherStation.SetMeasurements(10, 20);
    }
}