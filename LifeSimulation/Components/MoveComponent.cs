﻿using LifeSimulation.ActiveObjectInterfaces;
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
            throw new NotImplementedException();
        }

        void IUpdatable.Init()
        {
            throw new NotImplementedException();
        }

        void IComponent.SetCurrentCell()
        {
            throw new NotImplementedException();
        }

        void IUpdatable.Update()
        {
            throw new NotImplementedException();
        }

        IComponent IComponent.GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }
    }
}
