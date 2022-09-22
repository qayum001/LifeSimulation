using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
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

        ICreature IComponent.CurrentCreature { get; set; }

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

        void IComponent.SetCurrentCell(ICreature creature)
        {
            throw new NotImplementedException();
        }
    }
}
