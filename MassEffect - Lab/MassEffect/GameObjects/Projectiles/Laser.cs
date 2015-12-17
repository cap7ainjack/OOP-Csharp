using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class Laser : Projectile
    {
        public Laser(int damage) : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            targetShip.Shields -= Damage;

            if (Damage > targetShip.Shields)
            {
                int healthTotTake = Damage - targetShip.Shields;
                targetShip.Health -= healthTotTake;
            }
        }
    }
}
