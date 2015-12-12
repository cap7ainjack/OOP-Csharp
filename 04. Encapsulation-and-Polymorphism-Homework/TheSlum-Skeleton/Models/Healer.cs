using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Models
{
   public  class Healer : AdvancedCharacter, IHeal
    {
        private const int defaultHealingPoints = 60;
        private const int defaultDefencePoints = 50;
        private const int defaultHealthPoints = 75;
        private const int defaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, defaultHealthPoints, defaultDefencePoints, team, defaultRange)
        {
            this.HealingPoints = defaultHealingPoints;
        }

       public override Character GetTarget(IEnumerable<Character> targetsList)
       {
           return targetsList
               .Where(c => c.IsAlive)
               .Where(c => c.Id != this.Id)
               .Where(c => c.Team == this.Team)
               .OrderBy(c => c.HealthPoints)
               .FirstOrDefault();
       }

       public int HealingPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
