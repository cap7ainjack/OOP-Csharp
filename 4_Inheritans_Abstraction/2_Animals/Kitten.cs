using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender = Gender.Female) : base(name, age)
        {
        }

        public override void ProduceSount()
        {
            Console.WriteLine("Miauuuuu");
        }
    }
}
