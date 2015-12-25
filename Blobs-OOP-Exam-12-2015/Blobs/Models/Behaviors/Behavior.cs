using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models.Behaviors
{
    using Contracts;

    public abstract class Behavior : IBehave
    {
        protected const string ExceptionMessage = "Behavior can be triggered only once";

        public abstract void ApplyBehavior(IBlob currentBlob);


        public abstract void ApplyNegativeEffects(IBlob currentBlob);


        public bool EffectApplied { get; protected set; }

        public bool EffectAlreadyApplied { get; protected set; }

        protected bool ShouldDelayBeforeExecution { get; set; } = true;
    }
}
