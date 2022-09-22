using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulation.WorldInterfaces
{
    public interface IUpdatable
    {
        public void Init();
        public void Update();
    }
}
