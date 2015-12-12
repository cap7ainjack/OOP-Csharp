using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.GameEngine;
using TheSlum.Interfaces;

namespace TheSlum.Models
{
    public class Warrior : AttackableCharacter, IAttack
    {
        private const int defaultAttackPoints = 150;
        private const int defaultDefencePoints = 100;
        private const int defaultHealthPoints = 200;
        private const int defaultRange = 2;

        public Warrior(string id, int x, int y, Team team) 
            : base(id, x, y, defaultHealthPoints, defaultDefencePoints, team, defaultRange)
        {
            this.AttackPoints = defaultAttackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(c => c.IsAlive && c.Team != this.Team);
        }

    }
}
