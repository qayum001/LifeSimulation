using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.Creatures;
using LifeSimulation.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulation.Components
{
    public class DevideComponent : IComponent
    {
        private static IComponent _instance;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            Divide();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new DevideComponent();
            return _instance;
        }

        private void Divide()
        {
            TakeEnergyToAction();

            if (CurrentCreature.Energy < Params.CellDevideEnergy) return;

            var mapC = CurrentCreature.MapController;
            var lifeC = CurrentCreature.LifeController;

            var devidePos = mapC.GetDirectionPosition(CurrentCreature.Transform);

            if (!mapC.IsAvaible(devidePos) || !mapC.IsFree(devidePos)) return;

            var newCell = new AliveCell()
            {
                Energy = CurrentCreature.Energy / 2.0,
                LifeController = lifeC,
                MapController = mapC,
                Transform = new CreatureTransform.Transform()
                {
                    Position = devidePos,
                    Direction = CreatureTransform.Direction.LeftTop,
                }
            };

            CurrentCreature.Energy /= 2.0;

            newCell.Init();

            newCell.Brain.Mutate();

            lifeC.CreateCreature(newCell);

            System.Console.WriteLine("devided");
        }

        private void TakeEnergyToAction()
        {
            CurrentCreature.Energy -= Params.CellActionEnergy;
        }
    }
}
