using LifeSimulation.CreatureTransform;
using LifeSimulation.WorldInterfaces;
using LifeSimulation.WorldObjects;

namespace LifeSimulation.ActiveObjectInterfaces
{
    public interface ICreature : IUpdatable
    {
        double Energy { get; set; }

        LifeController LifeController { get; }

        MapController MapController { get; }

        Transform Transform { get; set; }
    }
}