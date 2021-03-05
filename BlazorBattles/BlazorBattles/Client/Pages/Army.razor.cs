using BlazorBattles.Client.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Pages
{
    public partial class Army
    {
        [Inject]
        public IUnitService Units { get; private set; }
    }
}
