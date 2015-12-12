using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models
{
   public class Pill : Bonus
    {
        private const int defaultHealtEffect = 0;
        private const int defaultDefenceEffect = 0;
        private const int defaultAttackEffect = 75;
        private const int timeoutTurns = 1;



        public Pill(string id)
            : base(id, defaultHealtEffect, defaultDefenceEffect, defaultAttackEffect)
        {
            this.Timeout = timeoutTurns;
            this.Countdown = timeoutTurns;
        }
    }
}
