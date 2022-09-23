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
        public Map Map { get; set; }
        public Environment Environment { get; set; }
        public ICreature[,] Creatures { get; set; }
        public LifeController Controller { get; set; }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
