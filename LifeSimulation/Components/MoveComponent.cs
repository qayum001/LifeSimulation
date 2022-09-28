using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;
using System;

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
            switch (CurrentCreature.Transform.Direction)
            {
                case 0:
                    CurrentCreature.Transform.X = CurrentCreature.Transform.X - 1;
                    CurrentCreature.Transform.Y = CurrentCreature.Transform.Y - 1;
                    break;
                case 1:
                    CurrentCreature.Transform.Y = CurrentCreature.Transform.Y - 1;
                    break;
                case 2:
                    CurrentCreature.Transform.X = CurrentCreature.Transform.X + 1;
                    CurrentCreature.Transform.Y = CurrentCreature.Transform.Y - 1;
                    break;
                case 3:
                    CurrentCreature.Transform.X = CurrentCreature.Transform.X + 1;
                    break;
                case 4:
                    CurrentCreature.Transform.X = CurrentCreature.Transform.X + 1;
                    CurrentCreature.Transform.Y = CurrentCreature.Transform.Y + 1;
                    break;
                case 5:
                    CurrentCreature.Transform.Y = CurrentCreature.Transform.Y - 1;
                    break;
                case 6:
                    CurrentCreature.Transform.X = CurrentCreature.Transform.X - 1;
                    CurrentCreature.Transform.Y = CurrentCreature.Transform.Y + 1;
                    break;
                case 7:
                    CurrentCreature.Transform.X = CurrentCreature.Transform.X - 1;
                    break;

            }
        }

        public void SetCurrentCell(ICreature creature) => CurrentCreature = creature;
    }
}
