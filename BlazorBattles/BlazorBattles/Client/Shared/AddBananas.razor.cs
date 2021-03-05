using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Shared
{
    public partial class AddBananas
    {
        [Parameter]
        public EventCallback<int> BananasAdded { get; set; } 


        public void IncreaseBananaCount()
        {
            BananasAdded.InvokeAsync(10);
        }
    }
}
