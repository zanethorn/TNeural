namespace TNeural
{
    public interface ISynapse:INeuralUnit
    {
        INeuron Input { get; internal set; }
        INeuron Output { get; internal set; }
           
        float Weight { get; set; }
    }
}