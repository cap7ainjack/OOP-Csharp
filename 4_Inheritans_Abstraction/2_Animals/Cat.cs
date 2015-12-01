using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public override void ProduceSount()
        {
            Console.WriteLine("Mayu Mayu");
        }
    }
}
