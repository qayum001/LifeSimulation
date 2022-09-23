using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.ComponentInterfaces
{
    public interface IComponent
    {
        ICreature CurrentCreature { get; set; }

        void Action();

        void SetCurrentCell(ICreature creature);

        IComponent GetComponentInstance();
    }
}