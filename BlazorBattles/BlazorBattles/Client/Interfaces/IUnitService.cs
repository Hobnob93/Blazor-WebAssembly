using BlazorBattles.Shared.Models;
using System.Collections.Generic;

namespace BlazorBattles.Client.Interfaces
{
    public interface IUnitService
    {
        IList<UnitTemplate> Templates { get; }
        IList<UnitInstance> Instances { get; }

        UnitTemplate FindTemplate(int unitId);
        void AddInstance(int unitId);
    }
}
