using System;

namespace BlazorBattles.Client.Interfaces
{
    public interface IBananaService
    {
        event Action OnChange;
        int Count { get; }

        void Consume(int amount);
        void Increase(int amount);
    }
}
