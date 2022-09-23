using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class AttackComponent : IComponent
    {
        private static IComponent _instance;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            throw new System.NotImplementedException();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        public void SetCurrentCell(ICreature creature) => CurrentCreature = creature;
    }
}
