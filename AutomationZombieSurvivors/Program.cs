using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AutomationZombieSurvivors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Seed initial Survivor
            var survivor1 = new Survivor { Name = "Jeff Probst" };
            var survivorList = new List<Survivor>();
            survivorList.Add(survivor1);

            var game = new Game();
          

            //Seed equipment 
            var equipmentSeed = new List<Equipment>();
            var equipment1 = new Equipment { Name = "Machete" };
            var equipment2 = new Equipment { Name = "Pistol" };
            var equipment3 = new Equipment { Name = "Hatchet" };
            equipmentSeed.Add(equipment1);
            equipmentSeed.Add(equipment2);
            equipmentSeed.Add(equipment3);

            //Seed Survivor 
            var survivorSeed = new List<Survivor>();
            var survivor2 = new Survivor { Name = "Dwayne" };
            var survivor3 = new Survivor { Name = "Bill" };
            var survivor4 = new Survivor { Name = "John" };
            survivorSeed.Add(survivor2);
            survivorSeed.Add(survivor3);
            survivorSeed.Add(survivor4);

        
            //Gameplay Loop
            while (survivorList.Exists(x => x.Alive == true))
            {
                foreach (Survivor survivor in survivorList.ToList())
                {
                    while (survivor.Actions > 0)
                    {
                        game.LootEquipment(survivor, equipmentSeed);
                        survivorList.Add(survivorSeed.FirstOrDefault());
                        survivor.Actions -= 1;
                    }
                }
               
            }
        }
    }
}
