using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Behaviors
{
    using Contracts;
   public class Inflated : Behavior
   {
       private int healthGain = 50;
       private int healthLoss = 10;
        

       public override void ApplyBehavior(IBlob currentBlob)
       {
           if (EffectAlreadyApplied)
           {
               throw new InvalidOperationException(ExceptionMessage);
           }

           EffectAlreadyApplied = true;
           EffectApplied = true;
           currentBlob.Health += healthGain;
       }

       public override void ApplyNegativeEffects(IBlob currentBlob)
       {
           if (ShouldDelayBeforeExecution)
           {
               ShouldDelayBeforeExecution = false;
           }

           else
           {
               currentBlob.Health -= healthLoss;
           }
       }
    }
}
