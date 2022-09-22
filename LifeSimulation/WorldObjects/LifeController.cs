using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.WorldObjects
{
    public class LifeController
    {
        private readonly IWorld _world;

        public LifeController(IWorld world)
        {
            _world = world;
        }

        public ICreature GetCreature()
        {
            return null;
        }

        public void CreateCreature(ICreature cell)
        {

        }

        public void RemoveCreature(ICreature cell)
        {

        }
    }
}
