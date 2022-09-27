using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.CreatureInterfaces;

namespace LifeSimulation.Creatures
{
    internal class AliveCellCreator : Creator
    {
        public override ICreature GetActiveCreature(string param)
        {
            return null;
        }
    }
}
