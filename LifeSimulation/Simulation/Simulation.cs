using System;
using System.Threading;

namespace LifeSimulation.Simulation
{
    public abstract class Simulation
    {
        private readonly Thread _mainLoop;
        private bool _doBreak;

        protected Simulation()
        {
            _doBreak = false;
            _mainLoop = new Thread(ThreadMeal);
        }

        private void ThreadMeal()
        {
            while (!_doBreak)
            {
                Update();
            }
        }

        public virtual void Init()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Init();
            _mainLoop.Start();
        }

        public void End()
        {
            _doBreak = true;
            _mainLoop?.Join();
        }
    }
}
