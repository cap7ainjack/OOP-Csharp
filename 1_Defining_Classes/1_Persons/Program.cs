using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 17,"peshaka@abv.bg");
            Person dimitri = new Person("Dima", 56);
            Person ivan = new Person("Ivan", 31, "vanchoreste@google");
            Person ivelina = new Person("Ivelina", 24, "ivelina@abv.bg");

           // dimitri.Name = "Dimitri";
           // dimitri.Age = 21;

            Console.WriteLine(pesho);
            Console.WriteLine(dimitri);
            Console.WriteLine(ivan);
            Console.WriteLine(ivelina);
        }
    }
}
