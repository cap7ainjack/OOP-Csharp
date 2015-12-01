using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_inteface
{
    public class Circle : shade
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }
        public override double GetArea() // always should override the abstract method from parent
        {
            return this.Radius*this.Radius*Math.PI;
        }
    }
}
