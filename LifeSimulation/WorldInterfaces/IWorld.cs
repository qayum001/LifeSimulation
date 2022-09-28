using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.WorldInterfaces
{
    public interface IWorld : IUpdatable
    {
        (int x, int y) MapSize { get; set; }

        Map Map { get; set; }

        Environment Environment { get; set; }

        ICreature[,] Creatures { get; set; }

        LifeController Controller { get; set; }
    }
}