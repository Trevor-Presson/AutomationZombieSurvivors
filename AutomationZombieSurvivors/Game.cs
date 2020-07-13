using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AutomationZombieSurvivors
{
    public class Game
    {
        public int Turn { get; set; }
        public int Level { get; set; }

        public static List<string> History { get; set; }

        public static Random RandomGen = new Random();
  

        public void LootEquipment (Survivor survivor, List<Equipment> equipmentSeed)
        {
            if (survivor.Equipped.Count()  < 2)
            {
                survivor.Equipped.Add(equipmentSeed.First());
                History.Add("Picked up equipment");

            }
            else if (survivor.InReserve.Count() < 3)
            {
                survivor.InReserve.Add(equipmentSeed.First());
                History.Add("Picked up equipment");
            }
        }

        public void CalculateLevel (Survivor survivor)
        {
            if (survivor.Experience > 6)
            {
                survivor.Level = 2;
                History.Add("Leveled Up");
            }
            if (survivor.Experience > 18)
            {
                survivor.Level = 2;
                History.Add("Leveled Up");
            }
            if (survivor.Experience > 42)
            {
                survivor.Level = 3;
                History.Add("Leveled Up");
            }
        }

        public void Fight (Survivor survivor)
        {
            //Kill Zombies 
            survivor.Experience += RandomGen.Next(0, 5);

            //Take Wounds
            int woundCount = RandomGen.Next(0, 1);

            if (woundCount != 0)
            {
                survivor.Wounds += woundCount;
                History.Add("Survivor is wounded");
            }
            

        }

        public void DeathCheck (Survivor survivor, List<Survivor> survivorList)
        {
            if(survivor.Wounds >= 2)
            {
                survivor.Alive = false;
                survivorList.Remove(survivor);
                History.Add("Survivor died");
            }

            //
            if (!survivorList.Any(x => x.Alive == false ))
            {
                History.Add("All survivors dead");
            }
        }

        public void CalculateGameLevel (List<Survivor> survivorList, Game game)
        {
            game.Level = survivorList.ToList().Max(x => x.Level);
            //Game level changes
        }

        //When survivor added 
        //When game began

        //public void DropEquipment(Survivor survivor)
        //{

        //}
    }
}
