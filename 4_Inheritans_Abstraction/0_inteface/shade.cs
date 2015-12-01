using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_inteface.Intefaces;

namespace _0_inteface
{
    public abstract class shade : IMovable
    {
        public ConsoleColor colour { get; set; }
        public double x { get; set; }
        public  double y { get; set; }

        public void Move(double detltaX, double deltaY)
        {
            this.x += detltaX;
            this.y += deltaY;
        }

        public abstract double GetArea();
    }
}
