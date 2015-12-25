using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Contracts
{
   public interface IBlob : IAttackable, IAttacker,  IUpdatable
    {
        string Name { get; }

        int Health { get; set; }

        int Damage { get; set; }

        bool IsAlive { get; }

        IBehave Behavior { get; }

        IAttack Attack { get; }
    }
}
