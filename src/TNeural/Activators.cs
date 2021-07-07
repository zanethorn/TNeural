using System;

namespace TNeural
{
    public delegate float Activator(float input);
    
    public static class Activators
    {
        public static readonly Activator ReLU = (i) => Math.Max(0.0f, i);
        public static readonly Activator Sigmoid = (i) => (float) (1.0 / (1 + Math.Exp(-i)));
        public static readonly Activator Tanh = (i) => (float) Math.Tanh(i);
        public static readonly Activator Identity = (i) => i;
    }
}