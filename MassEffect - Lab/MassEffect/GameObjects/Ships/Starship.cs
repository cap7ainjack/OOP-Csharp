using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
   public abstract class Starship : IStarship
    {
        private readonly List<Enhancement> enhancements;

        protected Starship(string name, int health, int shield, int damage, double fuel,
           StarSystem location)
       {
           this.Name = name;
           this.Health = health;
           this.Shields = shield;
           this.Damage = damage;
           this.Fuel = fuel;
           this.Location = location;
           this.enhancements = new List<Enhancement>();
       }

       public IEnumerable<Enhancement> Enhancements
       {
            get { return this.enhancements; }
       }


       public void AddEnhancement(Enhancement enhancement)
       {
           if (enhancement == null)
           {
               throw new ArgumentNullException("Enchancment cannot be null");
           }

           this.enhancements.Add(enhancement);
           this.ApplyEnhancment(enhancement);

       }

       private void ApplyEnhancment(Enhancement enhancement)
       {
           this.Damage += enhancement.DamageBonus;
           this.Shields += enhancement.ShieldBonus;
           this.Fuel += enhancement.FuelBonus;
       }

       public string Name { get; set; }
       public int Health { get; set; }
       public int Shields { get; set; }
       public int Damage { get; set; }
       public double Fuel { get; set; }
       public StarSystem Location { get; set; }

       public abstract IProjectile ProduceAttack();


       public virtual void RespondToAttack(IProjectile projectile)
       {
               projectile.Hit(this);
       }

       public override string ToString()
       {
            StringBuilder builder = new StringBuilder();
           builder.AppendLine(string.Format("--{0} - {1}", this.Name, this.GetType().Name));

           if (this.Health <= 0)
           {
               builder.Append("(Destroyed)");
           }
           else
           {
               builder.AppendLine(string.Format("-Location: {0}", this.Location.Name));
                builder.AppendLine(string.Format("-Health: {0}", this.Health));
                builder.AppendLine(string.Format("-Shields: {0}", this.Shields));
                builder.AppendLine(string.Format("-Damage: {0}", this.Damage));
                builder.AppendLine(string.Format("-Fuel: {0:F1}", this.Fuel));

               if (enhancements.Count == 0)
               {
                   builder.AppendLine("-Enhancements: N/A");
               }
               else
               {
                   builder.AppendLine(string.Format("-Enhancements: {0}", string.Join(", ", this.enhancements)));
               }

            }

           return builder.ToString().TrimEnd('\n');
       }
    }
}
