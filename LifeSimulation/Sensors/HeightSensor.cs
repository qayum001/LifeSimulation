using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class HeightSensor : ISensor
    {
        private static HeightSensor _instance;

        public double GetSense() { return 0; }

        public ISensor GetSensorInstance()
        {
            if( _instance == null )
                _instance = new HeightSensor();
            return _instance;
        }
    }
}
