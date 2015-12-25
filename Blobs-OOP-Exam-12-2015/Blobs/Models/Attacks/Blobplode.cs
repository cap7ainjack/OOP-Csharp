using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Attacks
{
    using Contracts;

    public  class Blobplode : Attack
    {
      public override void ExecuteAttack(IBlob target, int damage)
      {
          damage = damage*2;
            target.Respond(damage);
      }

        public override void ExecuteEffectsOnAttacker(IBlob attacker)
        {
            attacker.Health -= attacker.Health/2;
        }
    }
}
