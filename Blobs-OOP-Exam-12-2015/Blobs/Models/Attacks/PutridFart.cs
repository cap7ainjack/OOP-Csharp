using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Attacks
{
    using Contracts;

    public  class PutridFart : Attack
    {
        public override void ExecuteAttack(IBlob target, int damage)
        {
            target.Respond(damage);
        }

        public override void ExecuteEffectsOnAttacker(IBlob attacker)
        {
        }
    }
}
