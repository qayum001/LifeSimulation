using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldInterfaces;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.ActiveObjectInterfaces
{
    public interface ICreature : IUpdatable
    {
        double Energy { get; set; }

        LifeController lifeController { get; set; }

        Transform Transform { get; set; }
    }
}