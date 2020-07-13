using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationZombieSurvivors
{
    public class Survivor
    {
        public string Name { get; set; }
        public int Wounds { get; set; }
        public bool Alive { get; set; }
        public int Actions { get; set; }
        public List<Equipment> Equipped { get; set; }
        public List<Equipment> InReserve { get; set; }
        public int Level { get; set; }
        //public enum Level { Blue, Orange, Yellow, Red};
        public int Experience { get; set; }

        public Survivor()
        {
            Wounds = 0;
            Alive = true;
            Actions = 3;
            Equipped = new List<Equipment>();
            InReserve = new List<Equipment>();
            Experience = 0;
            Level = 1;
        }
    }

}
