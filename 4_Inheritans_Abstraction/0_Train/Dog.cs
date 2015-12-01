using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Train
{
    class Dog : Animal
    {
        public Dog(string name, int age, string breed, ConsoleColor colour) //colour is mandatory now
            :base(name,age,colour)
        {
            this.Breed = breed;
        }
        public string Breed { get; set; }
    }
}
