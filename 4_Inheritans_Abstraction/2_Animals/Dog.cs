using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
   public class Dog : Animal
    {
       public Dog(string name, int age) : base(name, age: age)
       {
       }

       public override void ProduceSount()
       {
           Console.WriteLine("Bark...");
       }
    }
}
