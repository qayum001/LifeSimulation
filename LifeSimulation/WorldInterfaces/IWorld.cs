using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.WorldInterfaces
{
    public interface IWorld : IUpdatable
    {
        public Map Map { get; set; }

        public Environment Environment { get; set; }

        public ICreature[,] Creatures { get; set; }

        public LifeController Controller { get; set; }
    }
}
