namespace BlazorBattles.Client.Interfaces
{
    public interface IBananaService
    {
        int Bananas { get; set; }

        void ConsumeBananas(int amount);
    }
}
