using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Attacks
{
    using Contracts;
    public abstract class Attack : IAttack
    {
        public abstract void ExecuteAttack(IBlob target, int damage);


        public abstract void ExecuteEffectsOnAttacker(IBlob attacker);

    }
}
