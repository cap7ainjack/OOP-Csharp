using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Animals
{
    public interface ISpeedCalculatable
    {
        int Speed { get; set; }
        double CalculateDistance(int hours);
    }

   public  abstract class Animals : ISpeedCalculatable
   {
       protected Animals(int speed)
       {
           this.Speed = speed;
       }
        public int Speed { get; set; }
       public abstract double CalculateDistance(int hours);

   }

    public class  Cheetah : Animals
    {
        public Cheetah(int speed) : base(speed)
        {
        }

        public override double CalculateDistance(int hours)
        {
            return 100*hours;
        }
    }
}
