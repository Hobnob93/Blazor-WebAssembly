using BlazorBattles.Client.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorBattles.Client.Pages
{
    public partial class Build
    {
        [Inject]
        public IBananaService Bananas { get; private set; }

        [Inject]
        public IUnitService Units { get; private set; }

        private int selectedUnitTemplateId = 1;
        private bool notEnoughBananas = false;


        public void BuildUnit()
        {
            var unitTemplate = Units.FindTemplate(selectedUnitTemplateId);
            notEnoughBananas = Bananas.Count < unitTemplate.Cost;

            if (notEnoughBananas)
                return;

            Bananas.Consume(unitTemplate.Cost);
            Units.AddInstance(unitTemplate.Id);
        }
    }
}
