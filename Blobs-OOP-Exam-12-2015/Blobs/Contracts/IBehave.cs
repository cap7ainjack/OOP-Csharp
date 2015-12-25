using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Contracts
{
  public  interface IBehave
  {
      void ApplyBehavior(IBlob currentBlob);

      void ApplyNegativeEffects(IBlob currentBlob);

      bool EffectApplied { get; }

        bool EffectAlreadyApplied { get; }
  }
}
