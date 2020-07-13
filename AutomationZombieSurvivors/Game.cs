using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationZombieSurvivors
{
    public class Game
    {
        public int Turn { get; set; }
        public int Level { get; set; }

        public static Random RandomGen = new Random();

        public void LootEquipment (Survivor survivor, List<Equipment> equipmentSeed)
        {
            if (survivor.Equipped.Count()  < 2)
            {
                survivor.Equipped.Add(equipmentSeed.First());
            }
            else if (survivor.InReserve.Count() < 3)
            {
                survivor.InReserve.Add(equipmentSeed.First());
            }
        }

        public void CalculateLevel (Survivor survivor)
        {
            if (survivor.Experience > 6)
            {
                survivor.Level = 2;
            }
            if (survivor.Experience > 18)
            {
                survivor.Level = 2;
            }
            if (survivor.Experience > 42)
            {
                survivor.Level = 3;
            }
        }

        public void Fight (Survivor survivor)
        {
            //Kill Zombies 
            survivor.Experience += RandomGen.Next(0, 5);

            //Take Wounds
            RandomGen.Next(0, 1);
        }

        public void DeathCheck (Survivor survivor)
        {
            if(survivor.Wounds >= 2)
            {
                survivor.Alive = false;
            }
        }

        public void CalculateGameLevel (List<Survivor> survivorList, Game game)
        {
            game.Level = survivorList.ToList().Max(x => x.Level);
        }

        //public void DropEquipment(Survivor survivor)
        //{

        //}
    }
}
