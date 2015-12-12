using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine("Rectagnle Area: " + Width*Height);
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Rectangle Perimeter: " + (2*Width + 2* Height));
        }
    }
}
