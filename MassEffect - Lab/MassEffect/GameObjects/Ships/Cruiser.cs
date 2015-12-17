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
   public class Cruiser: Starship
    {

        private const int DefaultCruiserHealth = 100;
        private const int DefaultCruiserShield = 100;
        private const int DefaultCruiserDamage = 50;
        private const int DefaultCruisereFuel = 300;

        public Cruiser(string name, StarSystem location) 
            : base(name, DefaultCruiserHealth, DefaultCruiserShield, DefaultCruiserDamage,
                  DefaultCruisereFuel, location)
       {
       }
        
       public override IProjectile ProduceAttack()
       {
          return new PenetrationShell(this.Damage);
       }


    }
}
