using System;
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

            //Action execution
            while (survivor.Actions > 0)
            {
                survivor.Actions -= 1;
            }
        }
    }
}
