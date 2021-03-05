using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Shared
{
    public partial class TopMenu
    {
        [Parameter]
        public int Bananas { get; set; } = 100;


        public void AddBananas(int amount)
        {
            Bananas += amount;
        }
    }
}
