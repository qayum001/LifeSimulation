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
        public LifeController Controller { get; set; }

        public World()
        {
            MapSize = new(100, 100);
            Map = new Map(MapSize);
            Environment = new Environment();
            Controller = new LifeController(this);
        }

        public void Init()
        {
            Map.Init();
            Environment.Init();
            Controller.CreateCreature(100);
        }

        public void Update()
        {
            UpdateEnvironment();
            UpdateCells();
        }

        #region Private Methods
        private void UpdateCells()
        {
            foreach(var cell in Creatures)
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