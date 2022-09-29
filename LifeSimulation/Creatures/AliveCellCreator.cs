using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.CreatureInterfaces;
using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.Creatures
{
    public class AliveCellCreator : Creator
    {
        public override ICreature GetActiveCreature(LifeController lifeController, MapController mapController, Position position)
        {
            return new AliveCell()
            {
                LifeController = lifeController,
                MapController = mapController,
                Transform = new Transform()
                {
                    Position = position,
                    Direction = Direction.LeftTop,                    
                }
            };
        }
    }
}
