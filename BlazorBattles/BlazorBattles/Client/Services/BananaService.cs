using BlazorBattles.Client.Interfaces;

namespace BlazorBattles.Client.Services
{
    public class BananaService : IBananaService
    {
        public int Bananas { get; set; }

        public void ConsumeBananas(int amount)
        {
            Bananas -= amount;
        }
    }
}
