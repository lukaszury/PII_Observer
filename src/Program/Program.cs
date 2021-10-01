namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {        
            ISubject<TemperatureSensor> sensor = new TemperatureSensor();
            IObserver<TemperatureReporter> reporter = new TemperatureReporter();
            reporter.StartReporting(sensor);
            sensor.GetTemperature();
        }
    }
}