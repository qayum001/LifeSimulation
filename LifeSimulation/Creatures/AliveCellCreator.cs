using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.CreatureInterfaces;

namespace LifeSimulation.Creatures
{
    public class AliveCellCreator : Creator
    {
        public override ICreature GetActiveCreature()
        {
            return new AliveCell();
        }
    }
}
