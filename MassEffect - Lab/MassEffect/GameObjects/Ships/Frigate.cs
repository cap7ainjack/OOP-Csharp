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
  public  class Frigate : Starship
  {
      private int projectilesFired;
      private const int DefaultFrigateHealth = 60;
      private const int DefaultFrigateShield = 50;
      private const int DefaultFrigateDamage = 30;
      private const int DefaultFrigateFuel = 220;

      public Frigate(string name, StarSystem location)
            : base(name, DefaultFrigateHealth, DefaultFrigateShield, DefaultFrigateDamage,
                  DefaultFrigateFuel, location)
      {
      }

      public override IProjectile ProduceAttack()
      {
          projectilesFired++;
         return new ShieldReaver(this.Damage);
      }



      public override string ToString()
      {
          string baseOutput = base.ToString();

          if (this.Health > 0)
          {
              baseOutput += string.Format("-Projectiles fired: {0}", this.projectilesFired);
          }

          return baseOutput;
      }
  }
}
