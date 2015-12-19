using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;

namespace Empires.Models.Units
{
   public abstract class Unit : IUnit
    {
       protected Unit(int attackDamage, int health)
       {
           AttackDamage = attackDamage;
           Health = health;
       }

       public int AttackDamage { get; }


       public int Health { get; }
    }
}
