using System;
using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class RotateComponent : IComponent
    {
        private static IComponent _instance;

        ICreature IComponent.CurrentCreature { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IComponent.Action()
        {
            throw new NotImplementedException();
        }

        IComponent IComponent.GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        void IComponent.SetCurrentCell()
        {
            throw new NotImplementedException();
        }
    }
}
