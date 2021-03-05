using BlazorBattles.Client.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BlazorBattles.Client.Shared
{
    public partial class TopMenu : IDisposable
    {
        [Inject]
        public IBananaService Bananas { get; private set; }


        protected override void OnInitialized()
        {
            Bananas.OnChange += StateHasChanged;
        }

        [SuppressMessage("Usage", "CA1816", Justification = "Dispose methods should call SuppressFinalize")]
        public void Dispose()
        {
            Bananas.OnChange -= StateHasChanged;
        }
    }
}
