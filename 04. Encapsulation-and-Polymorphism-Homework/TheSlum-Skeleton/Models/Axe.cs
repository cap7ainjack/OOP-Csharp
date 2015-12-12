using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models
{
    public class Axe : Item
    {
        private const int defaultHealtEffect = 0;
        private const int defaultDefenceEffect = 0;
        private const int defaultAttackEffect = 75;

        public Axe(string id)
            : base(id, defaultHealtEffect, defaultDefenceEffect, defaultAttackEffect)
        {

        }
    }
}
