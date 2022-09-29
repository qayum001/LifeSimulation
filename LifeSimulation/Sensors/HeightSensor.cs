using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class HeightSensor : ISensor
    {
        private static HeightSensor _instance;

        public ICreature CurrentCreature { get; set; }

        public double GetSense() => GetHeightСoefficient();

        public ISensor GetSensorInstance()
        {
            if( _instance == null )
                _instance = new HeightSensor();
            return _instance;
        }

        private double GetHeightСoefficient()
        {
            var currentHeight = CurrentCreature.Transform.Position.Y;
            var mapC = CurrentCreature.MapController;

            return ((double)currentHeight / mapC.Height);
        }
    }
}
