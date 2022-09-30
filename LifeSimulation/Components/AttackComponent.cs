using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;

namespace LifeSimulation.Components
{
    public class AttackComponent : IComponent
    {
        private static IComponent _instance;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            Attack();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new AttackComponent();
            return _instance;
        }

        private void Attack()
        {
            TakeEnergyToAction();

            var mapC = CurrentCreature.MapController;
            var lifeC = CurrentCreature.LifeController;
            var transform = CurrentCreature.Transform;


            var directionPos = mapC.GetDirectionPosition(transform);

            if (!mapC.IsAvaible(directionPos)) return;

            if (!mapC.IsFree(directionPos))
            {
                var targetCell = lifeC.GetCreature(directionPos);
                if (targetCell == null) return;
                CurrentCreature.Energy += targetCell.Energy;

                mapC.SetSpotStatus(true, targetCell.Transform.Position);
                lifeC.RemoveCreature(targetCell);
            }
        }

        private void TakeEnergyToAction()
        {
            CurrentCreature.Energy -= Params.CellActionEnergy;
        }
    }
}