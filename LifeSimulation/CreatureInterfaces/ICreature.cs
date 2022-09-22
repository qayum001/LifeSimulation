using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldInterfaces;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.ActiveObjectInterfaces
{
    public interface ICreature : IUpdatable
    {
        public double Energy { get; set; }

        protected LifeController lifeController { get; set; }

        public Transform Transform { get; set; }
    }
}