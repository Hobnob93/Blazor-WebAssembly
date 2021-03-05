using BlazorBattles.Shared.Models;
using System.Collections.Generic;

namespace BlazorBattles.Client.Interfaces
{
    public interface IUnitService
    {
        IList<Unit> Units { get; }
        IList<UserUnit> UserUnits { get; }

        void AddUnit(int unitId);
    }
}
