using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.CreatureInterfaces;
using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.Creatures
{
    public class AliveCell : IActiveCreature
    {
        public double Energy { get; private set; }
        public IComponent Components { get; private set; }
        public LifeController lifeController { get ; private set; }
        public Transform Transform { get; set; }

        public void Init()
        {
            
        }

        public void Update()
        {
            
        }
    }
}