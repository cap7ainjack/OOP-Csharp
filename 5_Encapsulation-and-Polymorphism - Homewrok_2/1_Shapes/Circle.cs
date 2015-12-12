using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Shapes.Interfaces;

namespace _1_Shapes
{
    class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }


        public void CalculateArea()
        {
            Console.WriteLine("Circle Area: " +(Math.Pow(Radius, 2)) * Math.PI);
         
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Circle Perimeter: " + (2*Math.PI) * Radius);
        }
    }
}
