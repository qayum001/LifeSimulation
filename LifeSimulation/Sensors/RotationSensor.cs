using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class RotationSensor : ISensor
    {
        private static RotationSensor _instance;

        public double GetSense() { return 0; }

        public ISensor GetSensorInstance()
        {
            if(_instance == null)
                _instance = new RotationSensor();
            return _instance;
        }
    }
}
