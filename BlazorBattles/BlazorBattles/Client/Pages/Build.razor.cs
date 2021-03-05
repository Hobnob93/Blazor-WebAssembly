using BlazorBattles.Client.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Pages
{
    public partial class Build
    {
        [Inject]
        public IBananaService Bananas { get; private set; }


        private void ConsumeBananas(int amount)
        {
            Bananas.Consume(amount);
        }
    }
}
