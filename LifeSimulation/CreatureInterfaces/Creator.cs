using LifeSimulation.ActiveObjectInterfaces;

namespace LifeSimulation.CreatureInterfaces
{
    public abstract class Creator
    {
        public abstract ICreature GetActiveCreature(string param);
    }
}
