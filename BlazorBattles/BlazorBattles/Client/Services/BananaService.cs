using BlazorBattles.Client.Interfaces;
using System;

namespace BlazorBattles.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Count { get; private set; } = 1000;


        private void CountChanged() => OnChange?.Invoke();

        public void Consume(int amount)
        {
            ModifyCount(-amount);
        }

        public void Increase(int amount)
        {
            ModifyCount(amount);
        }

        private void ModifyCount(int amount)
        {
            Count += amount;
            CountChanged();
        }
    }
}
