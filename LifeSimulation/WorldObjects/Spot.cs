using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulation.WorldObjects
{
    public class Spot
    {
        public bool IsFree { get; set; }
        public double SpotSunEnergy { get; set; }

        public Spot()
        {
            IsFree = false;
            SpotSunEnergy = 0.0f;
        }
    }
}
