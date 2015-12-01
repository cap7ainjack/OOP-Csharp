using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Train
{
    class Animal
    {
        public static int AnimalCounter = 0;
        private const ConsoleColor DefaultColour = ConsoleColor.Blue;
        private string name;
        private int age;

        public Animal(string name, int age, ConsoleColor colour = DefaultColour) //like this colour becomes optional
        {
            AnimalCounter++;
            this.Name = name;
            this.Age = age;
            this.Colour = colour;
        }

        public string Name {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.name = value;
            }
                }

        public int Age {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be a positive number");
                }

                this.age = value;
            }
        }

        public ConsoleColor Colour { get; set; }
    }
}
