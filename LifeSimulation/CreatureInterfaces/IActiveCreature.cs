using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.ControlPartInterfaces;
using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.CreatureInterfaces
{
    public interface IActiveCreature : ICreature
    {
        IComponent[] Components { get; }

        ISensor[] Sensors { get; }
    }
}
