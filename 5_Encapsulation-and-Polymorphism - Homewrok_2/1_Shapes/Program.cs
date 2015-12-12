using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Shapes.Interfaces;

namespace _1_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapesList = new List<IShape>()
            {
                new Rectangle(2.3,1.6),
                new Rhombus(1.2,6.4),
                new Circle(2)
            };

            shapesList[0].CalculateArea();
            shapesList[0].CalculatePerimeter();

            shapesList[1].CalculateArea();
            shapesList[1].CalculatePerimeter();

            shapesList[2].CalculateArea();
            shapesList[2].CalculatePerimeter();
        }
    }
}
