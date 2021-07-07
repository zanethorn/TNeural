using System.Collections.Generic;

namespace TNeural
{
    public interface INeuralLayer:INeuralUnit
    {

        IEnumerable<INeuron> Neurons { get; }
        
        INeuralNetwork Network { get; internal set; }
    }
}