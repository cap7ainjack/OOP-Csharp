using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
   public abstract class Animal : ISoundProducible
    {
       public Animal(string name, int age)
       {
           this.Name = name;
           this.Age = age;
       }

       public string Name { get; set; }
        public int Age { get; set; }

       public abstract void ProduceSount();

    }
}
