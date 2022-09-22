using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class AttackComponent : IComponent
    {
        private static IComponent _instance;

        ICreature IComponent.CurrentCreature { get; set; }

        void IComponent.Action()
        {
            throw new System.NotImplementedException();
        }

        IComponent IComponent.GetComponentInstance()
        {
            if (_instance == null)
                _instance = new MoveComponent();
            return _instance;
        }

        void IComponent.SetCurrentCell()
        {
            throw new System.NotImplementedException();
        }
    }
}
