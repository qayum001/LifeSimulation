using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.ComponentInterfaces
{
    public interface IComponent : IUpdatable
    {
        protected ICreature CurrentCreature { get; set; }

        public void Action();

        public void SetCurrentCell();

        public IComponent GetComponentInstance();
    }
}