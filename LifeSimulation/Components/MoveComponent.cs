using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;
using System;

namespace LifeSimulation.Components
{
    public class MoveComponent : IComponent
    {
        private static IComponent _instance;

        ICreature IComponent.CurrentCreature { get; set; }

        void IComponent.Action()
        {
            Move();
        }

        void IComponent.SetCurrentCell(ICreature creature)
        {
            throw new NotImplementedException();
        }

        IComponent IComponent.GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        private void Move()
        {

        }
    }
}
