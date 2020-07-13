using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AutomationZombieSurvivors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Seed survivor
            var survivor = new Survivor { Name = "Jeff Probst" };

            var combat = new Combat();

            //Seed equipment 
            var equipmentSeed = new List<Equipment>();
            var equipment1 = new Equipment { Name = "Machete" };
            var equipment2 = new Equipment { Name = "Pistol" };
            var equipment3 = new Equipment { Name = "Hatchet" };
            equipmentSeed.Add(equipment1);
            equipmentSeed.Add(equipment2);
            equipmentSeed.Add(equipment3);

            //survivor.Equipped.Add(equipment1);
            //survivor.Equipped.Add(equipment2);
            //survivor.Equipped.Add(equipment3);

            //Action execution
            while (survivor.Actions > 0)
            {
                combat.LootEquipment(survivor, equipmentSeed);
                survivor.Actions -= 1;
            }
        }
    }
}
