using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models
{
   public class Injection : Bonus
    {
        private const int defaultHealtEffect = 200;
        private const int defaultDefenceEffect = 0;
        private const int defaultAttackEffect = 0;
        private const int timeoutTurns = 3;



        public Injection(string id)
            : base(id, defaultHealtEffect, defaultDefenceEffect, defaultAttackEffect)
        {
            this.Timeout = timeoutTurns;
            this.Countdown = timeoutTurns;
        }
    }
}
