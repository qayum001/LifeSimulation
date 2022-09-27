using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.CreatureInterfaces;
using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.Creatures
{
    public class AliveCell : IActiveCreature
    {
        public double Energy { get; set; }

        public IComponent Components { get; }

        public LifeController lifeController { get ; set; }
        public Transform Transform { get; set; }

        public void Init()
        {
            
        }

        public void Update()
        {
            
        }
    }
}