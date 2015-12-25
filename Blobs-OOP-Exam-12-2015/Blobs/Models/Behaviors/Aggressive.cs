using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Behaviors
{
    using System.Runtime.CompilerServices;
    using Contracts;

    public class Aggressive : Behavior
    {
        private int damageReductionValue = 5;
        private int initialBloodDamage;


        public override void ApplyBehavior(IBlob currentBlob)
        {
            if (this.EffectAlreadyApplied)
            {
                throw new InvalidOperationException(ExceptionMessage);
            }

            this.EffectAlreadyApplied = true;
            this.EffectApplied = true;
            this.initialBloodDamage = currentBlob.Damage;
            currentBlob.Damage = currentBlob.Damage*2;

        }

        public override void ApplyNegativeEffects(IBlob currentBlob)
        {
            if (ShouldDelayBeforeExecution)
            {
                ShouldDelayBeforeExecution = false;
            }

            else
            {
                if (currentBlob.Damage - damageReductionValue < initialBloodDamage)
                {
                    this.EffectApplied = false;
                }

                else
                {
                    currentBlob.Damage -= damageReductionValue;
                }
            }
        }
    }
}
