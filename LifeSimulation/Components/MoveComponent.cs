using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class MoveComponent : IComponent
    {
        private static IComponent _instance;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            Move();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        private void Move()
        {

        }

        public void SetCurrentCell(ICreature creature) => CurrentCreature = creature;
    }
}
