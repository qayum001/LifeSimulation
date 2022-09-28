using LifeSimulation.WorldInterfaces;
using LifeSimulation.WorldObjects;

namespace LifeSimulation
{
    public class Simulation1 : Simulation.Simulation
    {
        private readonly IWorld _world;

        public Simulation1() : base()
        {
            _world = new World();
        }

        public override void Init()
        {
            _world.Init();
        }

        public override void Update()
        {
            _world.Update();
        }
    }
}
