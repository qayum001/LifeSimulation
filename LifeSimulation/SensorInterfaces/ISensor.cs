using LifeSimulation.ActiveObjectInterfaces;

namespace LifeSimulation.SensorInterfaces
{
    public interface ISensor
    {
        ICreature CurrentCreature { get; set; }

        double GetSense();

        ISensor GetSensorInstance();
    }
}