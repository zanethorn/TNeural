using TNeural.Utilities;

namespace TNeural
{
    public interface INeuralUnit:IUnique, IExpressable
    {
        void UpdateState();
    }
}