using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.Sensors
{
    public class EnergySensor : ISensor
    {
        private static EnergySensor _instance;

        public ICreature CurrentCreature { get; set; }

        public double GetSense() => GetSatiety();

        public ISensor GetSensorInstance()
        {
            if( _instance == null )
                _instance = new EnergySensor();
            return _instance;
        }

        private double GetSatiety()
        {
            return ((CurrentCreature.Energy - Params.CellMinEnergy) / (Params.CellEnergyCapacity - Params.CellMinEnergy));
        }
    }
}