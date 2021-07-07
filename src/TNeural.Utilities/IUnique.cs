using System;

namespace TNeural.Utilities
{
    public interface IUnique
    {
        Guid Id { get; set; }
        string Name { get; set; }

        string ToString()
        {
            return $"{GetType().Name} ({Id}, \"{Name}\")";
        }
    }
}