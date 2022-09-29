using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.WorldObjects
{
    public class World : IWorld
    {
        public (int x, int y) MapSize { get; set; }
        public Map Map { get; set; }
        public Environment Environment { get; set; }
        public ICreature[,] Creatures { get; set; }
        public LifeController LifeController { get; set; }
        public MapController MapController { get; set; }

        public World()
        {
            MapSize = new (100, 100);
            Map = new Map(MapSize);
            Environment = new Environment();
            Creatures = new ICreature[MapSize.x, MapSize.y];
            LifeController = new LifeController(this);
            MapController = new MapController(this);
        }

        public void Init()
        {
            Map.Init();
            Environment.Init();
            LifeController.CreateCreature(100);
            InitCells();
        }

        public void Update()
        {
            UpdateEnvironment();
            UpdateCells();
        }

        #region Private Methods
        private void InitCells()
        {
            foreach(var cell in Creatures)
            {
                cell?.Init();
            }
        }
        private void UpdateCells()
        {
            foreach (var cell in Creatures)
            {
                cell?.Update();
            }
        }
        private void UpdateEnvironment()//sets updated sun energy to map
        {
            Environment.Update();
            Map.SetAvaibleSunEnergy(Environment.AvailableSunEnergy);
            Map.Update();
        }
        #endregion
    }
}