using System.Collections;
using System.Collections.Generic;

namespace TNeural
{
    public interface INeuralNetwork: INeuralUnit
    {
        IEnumerable Layers { get; }

        float GetInput(int inputNumber);
        float GetInput(string inputName);
        void SetInput(int inputNumber, float value);
        void SetInput(string inputName, float value);

        float GetOutput(int outputNumber);
        float GetOutput(string outputName);

        IEnumerable<float> FeedForward(IEnumerable<float> input);
    }
}