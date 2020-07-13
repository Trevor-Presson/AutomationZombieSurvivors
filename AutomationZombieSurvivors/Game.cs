using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationZombieSurvivors
{
    public class Game
    {
        public int Turn { get; set; }

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

        public void AddSurvivor (List<>)

        //public void DropEquipment(Survivor survivor)
        //{

        //}
    }
}
