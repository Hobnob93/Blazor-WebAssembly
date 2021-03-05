using BlazorBattles.Client.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Shared
{
    public partial class AddBananas
    {
        [Inject]
        public IBananaService Bananas { get; private set; }


        public void IncreaseBananaCount()
        {
            Bananas.Increase(10);
        }
    }
}
