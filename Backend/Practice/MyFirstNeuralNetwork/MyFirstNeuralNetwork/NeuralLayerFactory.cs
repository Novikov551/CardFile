using MyFirstNeuralNetwork;

internal class NeuralLayerFactory
{
    public NeuralLayerFactory()
    {
    }

    public NeuralLayer CreateNeuralLayer(int neuronNumbers,
        IActivationFunction rectifiedActivationFuncion,
        IInputFunction weightedSumFunction)
    {
        var neurons = Enumerable.Range(0, neuronNumbers).Select(x => (INeuron)new Neuron(rectifiedActivationFuncion, weightedSumFunction)).ToList();
        return new NeuralLayer
        {
            Neurons = neurons,
        };
    }
}