using LifeSimulation.ControlPartInterfaces;
using LifeSimulation.CreatureInterfaces;
using LifeSimulation.NN;

namespace LifeSimulation.ControlPart
{
    public class Brain : IBrain
    {
        private readonly Topology _topology;
        private readonly NeuralNetwork _neuralNetwork;
        private readonly ISensesCollector _sensesCollector;

        public Brain(IActiveCreature cell)
        {
            _topology = new Topology(cell.Sensors.Length, cell.Components.Length, 3, 4);
            _neuralNetwork = new NeuralNetwork(_topology);
            _sensesCollector = new SensesCollector(cell.Sensors);
        }

        public int GetDecision()
        {
            var senses = _sensesCollector.GetSenses();

            var results = _neuralNetwork.FeedForward(senses);

            var desition = results[0];

            var index = 0;

            for (var i = 1; i < results.Length; i++)
            {
                if (results[i] < desition) continue;

                desition = results[i];
                index = i;
            }

            return index;
        }

        public void Mutate()
        {
            _neuralNetwork.Mutate();
        }
    }
}