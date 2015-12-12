using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Shapes.Interfaces;

namespace _1_Shapes
{
    public abstract class BasicShape : IShape
    {
        protected BasicShape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        private double Width { get; set; }
        private double Height { get; set; }


        public abstract void CalculateArea();


        public abstract void CalculatePerimeter();

    }
}
