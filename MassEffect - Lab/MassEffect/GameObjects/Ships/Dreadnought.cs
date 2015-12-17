using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
   public class Dreadnought : Starship
    {
        private const int DefaultDreadnoughtHealth = 200;
        private const int DefaultDreadnoughtShield = 300;
        private const int DefaultDreadnoughtDamage = 150;
        private const int DefaultDreadnoughtFuel = 700;

        public Dreadnought(string name, StarSystem location) 
            : base(name, DefaultDreadnoughtHealth, DefaultDreadnoughtShield, DefaultDreadnoughtDamage, 
                  DefaultDreadnoughtFuel, location)
       {

       }

       public override IProjectile ProduceAttack()
       {
           return new Laser(this.Damage + (this.Shields/2));
       }

       public override void RespondToAttack(IProjectile projectile)
       {
           this.Shields += 50;
         base.RespondToAttack(projectile); 
           this.Shields -= 50;
       }
    }
}
