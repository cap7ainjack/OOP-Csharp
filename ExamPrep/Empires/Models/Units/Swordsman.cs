using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Units
{
    public class Swordsman : Unit
    {
        const int SwordsmanHealth = 40;
        const int SwordsmanAttackDamage = 13;

        public Swordsman()
            : base(SwordsmanAttackDamage, SwordsmanHealth)
        {
        }
    }
}
