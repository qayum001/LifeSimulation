using LifeSimulation.CreatureTransform;
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

        public bool IsFree(Position position)
        {
            return Spots[position.X, position.Y].IsFree;
        }

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
                double currentSunEnergy = 1.3 - (_mapSize.y / i); // helps to set sun energy for each level of map
                for(int j = 0; j < _mapSize.x; j++)
                {
                    Spots[j, i].SpotSunEnergy = _availableSunEnergy * currentSunEnergy;
                }
            }
        }
    }
}
