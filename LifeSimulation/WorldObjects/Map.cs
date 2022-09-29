﻿using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.WorldObjects
{
    public class Map : IUpdatable
    {
        private (int x, int y) _mapSize;
        private double _availableSunEnergy;
        public Spot[,] Spots { get; set; }

        public Map((int x, int y) mapSize)
        {
            _mapSize = mapSize;
        }

        public void Init()
        {
            InitSpots();
        }

        public void Update()
        {
            UpdateSpotsSunEnergy();
        }

        public void SetAvaibleSunEnergy(double avaibleSunEnergy)
        {
            _availableSunEnergy = avaibleSunEnergy;
        }

        public bool IsFree(Transform transform)
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

            return false;
        }

        public bool IsFree(Position position)
        {
            return Spots[position.X, position.Y].IsFree;
        }

        public bool IsAvaible(Position position)
        {
            return position.X >= 0 && position.Y >= 0 && position.X < _mapSize.x && position.Y < _mapSize.y;
        }
        #region Private Methods
        private void InitSpots()
        {
            _availableSunEnergy = 0.0;

            Spots = new Spot[_mapSize.x, _mapSize.y];
            
            for(int i = 0; i < _mapSize.x; i++)
            {
                for(int j = 0; j < _mapSize.y; j++)
                {
                    Spots[i, j] = new Spot();
                }
            }
        }
        
        private void UpdateSpotsSunEnergy()
        {
            for( int i = 0; i < _mapSize.y; i++)
            {
                double currentSunEnergy = 1.1 - ((_mapSize.y - i) / _mapSize.y); // helps to set sun energy for each level of map
                for(int j = 0; j < _mapSize.x; j++)
                {
                    Spots[j, i].SpotSunEnergy = _availableSunEnergy * currentSunEnergy;
                }
            }
        }
        #endregion
    }
}
