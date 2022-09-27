using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class EnergySensor : ISensor
    {
        private static EnergySensor _instance;

        public double GetSense() { return 0; }

        public ISensor GetSensorInstance()
        {
            if( _instance == null )
                _instance = new EnergySensor();
            return _instance;
        }
    }
}