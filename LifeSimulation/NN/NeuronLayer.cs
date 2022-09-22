namespace LifeSimulation.NN
{
    public class NeuronLayer
    {
        public Neuron[] Neurons { get; }
        public int LayerNeuronsCount { get; }
        private NeuronType _neuronType;

        public NeuronLayer(Neuron[] neurons, int layerNeuronsCount, NeuronType neuronType = NeuronType.Hidden)
        {
            Neurons = neurons;
            LayerNeuronsCount = layerNeuronsCount;
            _neuronType = neuronType;
        }

        public double[] LayerOutputsArray()
        {
            var outputs = new double[LayerNeuronsCount];
            for (var i = 0; i < LayerNeuronsCount; i++)
            {
                outputs[i] = Neurons[i].Output;
            }

            return outputs;
        }
    }
}
