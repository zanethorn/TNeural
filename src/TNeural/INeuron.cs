using System.Collections.Generic;

namespace TNeural
{
    public interface INeuron:INeuralUnit
    {
        IList<ISynapse> Input { get; }
        
        IList<ISynapse> Output { get; }
        
        float Bias { get; set; }
        
        float State { get; set; }
        
        Activator ActivationFunction { get; set; }
        
        INeuralLayer Layer { get; internal set; }

        INeuralNetwork Network => Layer.Network;
        
        
    }
}