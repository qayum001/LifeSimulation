using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class MoveComponent : IComponent
    {
        private static IComponent _instance;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            Move();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        private void Move()
        {
            TakeEnergyToAction();

            var mapC = CurrentCreature.MapController;

            var lifeC = CurrentCreature.LifeController;

            var currentPos = CurrentCreature.Transform.Position;

            var directionPos = mapC.GetDirectionPosition(CurrentCreature.Transform);

            if (!mapC.IsAvaible(directionPos) || !mapC.IsFree(directionPos)) return;

            System.Console.WriteLine("moved");

            lifeC.SetCellMovement(currentPos, null);

            mapC.SetSpotStatus(true, currentPos);
            
            CurrentCreature.Transform.Position = directionPos;

            lifeC.SetCellMovement(currentPos, CurrentCreature);

            mapC.SetSpotStatus(false, directionPos);
        }

        private void TakeEnergyToAction()
        {
            CurrentCreature.Energy -= Params.CellActionEnergy;
        }
    }
}
