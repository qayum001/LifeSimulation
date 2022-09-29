using System;
using System.Linq;

namespace LifeSimulation.NN
{
    public class Neuron
    {
        public double[] Weights { get; }
        //public double[] Inputs { get; }//uncomment to learn
        private readonly NeuronType _neuronType;
        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType neuronType = NeuronType.Hidden)
        {
            Weights = new double[inputCount];
            //Inputs = new double[inputCount];
            _neuronType = neuronType;
        }

        public void SetRandomWeightsFromArray(double[] array)
        {
            for (var i = 0; i < Weights.Length; i++)
            {
                Weights[i] = array[i];
            }
        }

        public double FeedForward(double[] signals)
        {
            var sum = 0.0;
            if (_neuronType == NeuronType.Input)
            {
                sum += signals.Sum();

                Output = sum;
                return sum;
            }

            sum += signals.Sum() * Weights.Sum();

            Output = Sigmoid(sum);
            return Output;
        }

        private double Sigmoid(double a)
        {
            var res = 1.0 / (1.0 + Math.Pow(Math.E, -a));
            return res;
        }
    }
}