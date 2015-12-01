using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Sharo", 13, colour: ConsoleColor.Black);

            //Animal animal = new Animal();
            //animal.Name = "Sharo";
            //animal.Age = 13;
            //animal.Colour = ConsoleColor.Black;


            Dog doggy = new Dog("Goshto", 3, "Koli",ConsoleColor.Black);
            //Dog doggy = new Dog();
            //doggy.Name = "Gosho";
            //doggy.Breed = "German Shepard";
        }
    }
}
