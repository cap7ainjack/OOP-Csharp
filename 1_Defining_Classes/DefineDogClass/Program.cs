using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineDogClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog("Sharo", "Deutscher Schäferhund");
            Dog unamedDog = new Dog();

            unamedDog.Breed = "unknown";

            unamedDog.Bark();
            sharo.Bark();
        }
    }
}
