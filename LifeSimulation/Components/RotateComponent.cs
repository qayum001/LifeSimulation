using System;
using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class RotateComponent : IComponent
    {
        private static IComponent _instance;

        private Random _random;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            Rotate();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new RotateComponent();
            return _instance;
        }

        private void Rotate()
        {
            TakeEnergyToAction();

            _random = new Random();

            CurrentCreature.Transform.Direction = CreatureTransform.Direction.LeftTop + _random.Next(8);
        }
        
        private void TakeEnergyToAction()
        {
            CurrentCreature.Energy -= Params.CellActionEnergy;
        }
    }
}
