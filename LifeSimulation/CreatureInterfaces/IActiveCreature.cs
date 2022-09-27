using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;

namespace LifeSimulation.CreatureInterfaces
{
    public interface IActiveCreature : ICreature
    {
        IComponent Components { get; }
    }
}
