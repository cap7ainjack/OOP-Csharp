using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Shapes
{
    public class Rhombus :BasicShape
    {
        public Rhombus(double width, double height) : base(width, height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine("Rhombus area: " + Width * Height);
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Rhombus perimeter: " + 4*Width);
        }
    }
}
