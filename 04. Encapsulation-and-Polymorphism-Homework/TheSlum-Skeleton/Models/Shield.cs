using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models
{
    public class Shield : Item
    {
        private const int defaultHealtEffect = 0;
        private const int defaultDefenceEffect = 50;
        private const int defaultAttackEffect = 0;

        public Shield(string id)
            : base(id, defaultHealtEffect, defaultDefenceEffect, defaultAttackEffect)
        {

        }
    }
}
