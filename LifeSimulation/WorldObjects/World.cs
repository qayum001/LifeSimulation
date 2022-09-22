using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulation.WorldObjects
{
    public class World : IWorld
    {
        Map IWorld.Map { get; set; }
        Environment IWorld.Environment { get; set; }
        ICreature[,] IWorld.Creatures { get; set; }
        LifeController IWorld.Controller { get; set; }

        void IUpdatable.Init()
        {
            throw new NotImplementedException();
        }

        void IUpdatable.Update()
        {
            throw new NotImplementedException();
        }
    }
}
