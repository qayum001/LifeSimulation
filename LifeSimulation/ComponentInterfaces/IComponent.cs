using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.ComponentInterfaces
{
    public interface IComponent
    {
        protected ICreature CurrentCreature { get; set; }

        public void Action();

        public void SetCurrentCell(ICreature creature);

        public IComponent GetComponentInstance();
    }
}