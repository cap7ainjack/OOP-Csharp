using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _0_WirkingWithAbstraction.Characters;
using _0_WirkingWithAbstraction.Interfaces;

namespace _0_WirkingWithAbstraction
{
    class Program 
    {
        static void Main(string[] args)
        {
           Character mage = new Mage();
            Priest priest = new Priest();
            Character warrior = new Warrior();
            
            mage.Attack(warrior);
            Console.WriteLine($"Mage does {mage.Damage} damage to warrior (Warrior current healt {warrior.Health})");
            priest.Heal(warrior);
            Console.WriteLine($"Priest heal the warrior. Warrior health: {warrior.Health}");
            priest.Attack(mage);
            Console.WriteLine($"Mage take damage from priest, mage health: {mage.Health}");

            if (mage.Health <= 0)
            {
                Console.WriteLine("Mage is dead");
            }


        }

     
    }
}
