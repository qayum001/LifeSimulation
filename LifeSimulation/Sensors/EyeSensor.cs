using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class EyeSensor : ISensor
    {
        private static EyeSensor _instance;

        public double GetSense() { return 0; }

        public ISensor GetSensorInstance()
        {
            if( _instance == null )
                _instance = new EyeSensor();
            return _instance;
        }
    }
}
