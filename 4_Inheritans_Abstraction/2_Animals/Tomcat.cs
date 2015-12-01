using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender = Gender.Male) : base(name, age)
        {
        }

        public override void ProduceSount()
        {
            Console.WriteLine("May... I`m a talking TomCat ;)");
        }
    }
}
