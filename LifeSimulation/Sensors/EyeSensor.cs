using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class EyeSensor : ISensor
    {
        private static EyeSensor _instance;
        public ICreature CurrentCreature { get; set; }

        public double GetSense() => Look();

        public ISensor GetSensorInstance()
        {
            if( _instance == null )
                _instance = new EyeSensor();
            return _instance;
        }

        private double Look()
        {
            var mapC = CurrentCreature.MapController;
            var directionPos = mapC.GetDirectionPosition(CurrentCreature.Transform);

            if (!mapC.IsAvaible(directionPos)) return 0.0;

            return mapC.IsFree(directionPos) ? 1.0 : 0.0;
        }
    }
}
