using BlazorBattles.Client.Interfaces;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Pages
{
    public partial class Build
    {
        [Inject]
        public IBananaService Bananas { get; private set; }

        [Inject]
        public IUnitService Units { get; private set; }

        [Inject]
        public IToastService Toast { get; private set; }

        private int selectedUnitTemplateId = 1;


        public void BuildUnit()
        {
            var unitTemplate = Units.FindTemplate(selectedUnitTemplateId);
            var notEnoughBananas = Bananas.Count < unitTemplate.Cost;

            if (notEnoughBananas)
            {
                Toast.ShowError("Not enough bananas! :(");
                return;
            }

            Bananas.Consume(unitTemplate.Cost);
            Units.AddInstance(unitTemplate.Id);
        }
    }
}
