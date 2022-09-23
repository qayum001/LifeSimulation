using System;
using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class RotateComponent : IComponent
    {
        private static IComponent _instance;
        
        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            throw new NotImplementedException();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        public void SetCurrentCell(ICreature creature) => CurrentCreature = creature;
    }
}
