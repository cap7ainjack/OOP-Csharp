using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
    public class Frog: Animal
    {
        public Frog(string name, int age) : base(name, age)
        {
        }

        public override void ProduceSount()
        {
            Console.WriteLine("Kwa Kwa Kwaaa");
        }
    }
}
