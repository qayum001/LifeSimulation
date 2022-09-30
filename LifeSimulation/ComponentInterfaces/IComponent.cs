using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.ComponentInterfaces
{
    public interface IComponent
    {
        ICreature CurrentCreature { get; set; }

        void Action();

        IComponent GetComponentInstance();
    }
}