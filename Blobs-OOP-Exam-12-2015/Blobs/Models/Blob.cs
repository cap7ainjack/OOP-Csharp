using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Models
{
    using Attacks;
    using Behaviors;
    using Contracts;

   public class Blob :IBlob
   {
       private int health;
       private readonly int halfhealth;

       public Blob(string name, int health, int damage, IBehave behavior, IAttack attack)
       {
           this.Name = name;
           this.Health = health;
           this.Damage = damage;
           this.Behavior = behavior;
           this.Attack = attack;

           this.halfhealth = this.Health/2;
       }

        public string Name { get; }

       public int Health
       {
           get { return this.health; }

           set
           {
               this.health = value;

               if (this.health < 0)
               {
                   this.health = 0;

                   if (this.Behavior.EffectAlreadyApplied)
                   {
                       Console.WriteLine($"Blob {this.Name} was killed");
                   }
               
               }

               if (this.health  <= halfhealth && !this.Behavior.EffectAlreadyApplied)
               {
                   this.Behavior.ApplyBehavior(this);
                   //Console.WriteLine($"Blob {this.Name} toggled {this.Behavior.GetType().Name}Behavior");
               }

           }
       }


        public int Damage { get; set; }

       public bool IsAlive
       {
           get { return this.Health > 0; }
       }



       public IBehave Behavior { get; }
        public IAttack Attack { get; }
        


        public void Respond(int damage)
        {
            this.Health -= damage;
        }

       public void PerformAttack(IBlob target)
       {
           this.Attack.ExecuteEffectsOnAttacker(this);
            this.Attack.ExecuteAttack(target, this.Damage);
       }

       public void Update()
       {
           if (this.Behavior.EffectApplied)
           {
               this.Behavior.ApplyNegativeEffects(this);
           }
       }

        public override string ToString()
        {
            if (this.Health <= 0)
            {
                return $"Blob {this.Name} KILLED";
            }

            return $"Blob {this.Name}: {this.Health} HP, {this.Damage} Damage";
        }


    }
}
