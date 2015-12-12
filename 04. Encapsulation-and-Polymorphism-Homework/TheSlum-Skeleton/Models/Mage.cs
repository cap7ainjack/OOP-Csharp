using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.GameEngine;
using TheSlum.Interfaces;

namespace TheSlum.Models
{
   public class Mage : AttackableCharacter,IAttack
    {
        private const int defaultAttackPoints = 300;
        private const int defaultDefencePoints = 50;
        private const int defaultHealthPoints = 150;
        private const int defaultRange = 5;

        public Mage(string id, int x, int y,  Team team) 
            : base(id, x, y, defaultHealthPoints, defaultDefencePoints, team, defaultRange)
        {
            this.AttackPoints = defaultAttackPoints;
        }

       public override Character GetTarget(IEnumerable<Character> targetsList)
       {
           return targetsList.LastOrDefault(c => c.IsAlive && c.Team != this.Team);
       }

    }
}
