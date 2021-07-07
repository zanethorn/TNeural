namespace TNeural.Utilities
{
    public interface IRandom
    {
        float Next();
        int NextInt(int min, int max);
    }
}