using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.Creatures;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.WorldObjects
{
    public class LifeController
    {
        private readonly IWorld _world;

        public LifeController(IWorld world)
        {
            _world = world;
        }

        public ICreature GetCreature()
        {
            return null;
        }

        public void CreateCreature(ICreature cell)
        {

        }
        /// <summary>
        /// creates first creatures to start simulation
        /// </summary>
        public void CreateCreature(int count)
        {
            int currentCount = 0;
            for(int i = 0; i < _world.MapSize.x; i++)
            {
                if (currentCount >= count) return;

                for(int j = 0; j < _world.MapSize.y; j++)
                {
                    _world.Creatures[i, j] = AliveCell.GetInstance();
                    currentCount++;
                }
            }
        }

        public void RemoveCreature(ICreature cell)
        {

        }
    }
}
