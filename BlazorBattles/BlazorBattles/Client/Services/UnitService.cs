using BlazorBattles.Client.Interfaces;
using BlazorBattles.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units { get; private set; }
        public IList<UserUnit> UserUnits { get; private set; }


        public UnitService()
        {
            Units = new List<Unit>
            {
                new Unit { Id = 1, Title = "Knight", Damage = 10, Defense = 10, Cost = 100 },
                new Unit { Id = 2, Title = "Archer", Damage = 15, Defense = 5, Cost = 150 },
                new Unit { Id = 3, Title = "Mage", Damage = 20, Defense = 1, Cost = 200 }
            };

            UserUnits = new List<UserUnit>();
        }

        public void AddUnit(int unitId)
        {
            var unit = Units.Single(u => u.Id == unitId);
            UserUnits.Add(new UserUnit { UnitId = unit.Id, Health = unit.Health });
        }
    }
}
