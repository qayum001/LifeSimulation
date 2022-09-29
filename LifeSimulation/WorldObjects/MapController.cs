using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.WorldObjects
{
    public class MapController
    {
        private readonly Map _map;
        private readonly IWorld _world;
        private readonly (int x, int y) _mapSize;

        public int Height { get; private set; }
        public int Width { get; private set; }  

        public MapController(IWorld world)
        {
            _world = world;
            _map = world.Map;
            _mapSize = _world.MapSize;

            Height = _mapSize.y;
            Width = _mapSize.x;
        }

        public Position GetDirectionPosition(Transform transform)
        {
            var direction = transform.Direction;

            var currentPosition = transform.Position;
            var newPosition = new Position(0, 0);

            switch (direction)
            {
                case Direction.LeftTop:
                    newPosition.X = currentPosition.X - 1;
                    newPosition.Y = currentPosition.Y - 1;
                    break;
                case Direction.Top:
                    newPosition.X = currentPosition.X;
                    newPosition.Y = currentPosition.Y - 1;
                    break;
                case Direction.RightTop:
                    newPosition.X = currentPosition.X + 1;
                    newPosition.Y = currentPosition.Y - 1;
                    break;
                case Direction.Right:
                    newPosition.X = currentPosition.X + 1;
                    newPosition.Y = currentPosition.Y;
                    break;
                case Direction.RightBottom:
                    newPosition.X = currentPosition.X + 1;
                    newPosition.Y = currentPosition.Y + 1;
                    break;
                case Direction.Bottom:
                    newPosition.X = currentPosition.X;
                    newPosition.Y = currentPosition.Y + 1;
                    break;
                case Direction.LeftBottom:
                    newPosition.X = currentPosition.X - 1;
                    newPosition.Y = currentPosition.Y + 1;
                    break;
                case Direction.Left:
                    newPosition.X = currentPosition.X - 1;
                    newPosition.Y = currentPosition.Y;
                    break;
            }

            return newPosition;
        }

        public bool IsFree(Position position)
        {
            return _map.Spots[position.X, position.Y].IsFree;
        }

        public bool IsAvaible(Position position)
        {
            return position.X >= 0 && position.Y >= 0 && position.X < _mapSize.x && position.Y < _mapSize.y;
        }
    }
}
