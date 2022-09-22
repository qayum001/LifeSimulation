using LifeSimulation.ThreadControll;

namespace LifeSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simulation = new Simulation1();
            var threadControll = new ThreadController(simulation);

            simulation.Start();
            threadControll.Start();
        }
    }
}