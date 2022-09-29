using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.CreatureInterfaces;
using LifeSimulation.CreatureTransform;
using LifeSimulation.Creatures;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.WorldObjects
{
    public class LifeController
    {
        private readonly IWorld _world;
        private readonly Creator _cellCreator;

        public LifeController(IWorld world)
        {
            _world = world;
            _cellCreator = new AliveCellCreator();
        }

        public ICreature GetCreature(Position position)
        {
            if (_world.Creatures[position.X, position.Y] != null)
                return _world.Creatures[position.X, position.Y];
            return null;
        }

        public void CreateCreature(ICreature cell)
        {
            var cellPos = cell.Transform.Position;

            if (!_world.Map.IsFree(cellPos)) return;

            _world.Creatures[cellPos.X, cellPos.Y] = cell;
        }

        public void CreateCreature(int count)// creates first creatures to start simulation
        {
            int currentCount = 0;
            for(int i = 0; i < _world.MapSize.x; i++)
            {
                if (currentCount >= count) return;

                for(int j = 0; j < _world.MapSize.y; j++)
                {
                    _world.Creatures[i, j] = _cellCreator.GetActiveCreature(this, _world.MapController, new Position(i, j));
                    currentCount++;
                }
            }
        }

        public void RemoveCreature(ICreature cell)
        {
            var position = cell.Transform.Position;

            _world.Creatures[position.X, position.Y] = null;
        }
    }
}
