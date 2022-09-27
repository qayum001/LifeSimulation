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

        public void Init()
        {
            MapSize = new(100, 100);
        }

        public void Update()
        {
            Environment.Update();
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
        #endregion
    }
}