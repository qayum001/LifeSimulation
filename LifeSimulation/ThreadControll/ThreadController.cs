using System;
using System.Threading;

namespace LifeSimulation.ThreadControll
{
    public class ThreadController
    {
        private readonly Thread _controllThread;
        private readonly Simulation.Simulation _simulation;
        public ThreadController(Simulation.Simulation simulation)
        {
            _controllThread = new Thread(ThreadMeal);
            _simulation = simulation;
        }

        private void ThreadMeal()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    _simulation.End();
                    return;
                }
            }
        }

        public void Start()
        {
            _controllThread.Start();
        }
    }
}
