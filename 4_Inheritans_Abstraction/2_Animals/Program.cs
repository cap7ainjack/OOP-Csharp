using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listOfAnimals = new List<Animal>()
            {
                new Cat("Kotio", 2),
                new Cat("Tomy", 4),
                new Cat("Vyglen", 1),
                new Cat("Rumpel", 5),
                new Dog("Vihar", 5),
                new Dog("Sharo", 7),
                new Dog("Bella", 4),
                new Dog("Jery", 8),
                new Frog("Prince", 1),
                new Tomcat("Tom", 4),
                new Kitten("Daisy", 3),
            };

            listOfAnimals[3].ProduceSount();

            listOfAnimals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderByDescending(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine($"{group.AnimalName} average age is {group.AverageAge}"));

            Console.WriteLine();

            listOfAnimals
                .Where(x => x.Name.Length < 5)
                .OrderBy(st => st.Name.Length)
                .ToList()
                .ForEach(z => Console.WriteLine(z.Name));
        }
    }
}
