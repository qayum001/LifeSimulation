using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.CreatureInterfaces
{
    public abstract class Creator
    {
        public abstract ICreature GetActiveCreature(LifeController lifeController, MapController mapController, Position position);
    }
}
