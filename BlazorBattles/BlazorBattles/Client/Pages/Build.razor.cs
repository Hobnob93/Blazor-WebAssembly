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


        public void BuildUnit()
        {
            var unitTemplate = Units.FindTemplate(selectedUnitTemplateId);
            Bananas.Consume(unitTemplate.Cost);
            Units.AddInstance(unitTemplate.Id);
        }
    }
}
