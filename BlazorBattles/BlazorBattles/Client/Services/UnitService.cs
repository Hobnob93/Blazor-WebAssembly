using BlazorBattles.Client.Interfaces;
using BlazorBattles.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<UnitTemplate> Templates { get; private set; }
        public IList<UnitInstance> Instances { get; private set; }


        public UnitService()
        {
            Templates = new List<UnitTemplate>
            {
                new UnitTemplate { Id = 1, Title = "Knight", Damage = 10, Defense = 10, Cost = 100 },
                new UnitTemplate { Id = 2, Title = "Archer", Damage = 15, Defense = 5, Cost = 150 },
                new UnitTemplate { Id = 3, Title = "Mage", Damage = 20, Defense = 1, Cost = 200 }
            };

            Instances = new List<UnitInstance>();
        }


        public UnitTemplate FindTemplate(int unitId)
        {
            return Templates.Single(u => u.Id == unitId);
        }

        public void AddInstance(int unitId)
        {
            var unit = Templates.Single(u => u.Id == unitId);
            Instances.Add(new UnitInstance { UnitId = unit.Id, Health = unit.Health });

            Console.WriteLine($"{unit.Title} was built!");
            Console.WriteLine($"Your army size: {Instances.Count}");
        }
    }
}
