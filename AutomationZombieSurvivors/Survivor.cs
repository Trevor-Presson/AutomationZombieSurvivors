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

        public Survivor()
        {
            Wounds = 0;
            Alive = true;
            Actions = 3;
        }
    }
}
