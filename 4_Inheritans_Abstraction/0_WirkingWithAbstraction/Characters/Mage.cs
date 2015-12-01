using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_WirkingWithAbstraction.Characters
{
    public class Mage : Character
    {
        public Mage() : base(100, 300, 75)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= 2*this.Damage;
            this.Mana -= 100;
        }
    }
}
