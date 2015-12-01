using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_EXR_Inheritans_Abastraction
{
    class Program
    {
        static void Main(string[] args)
        {
            book podIgoto = new book("Pod igoto", "Ivan Vazov", 15.0m);
           GoldenBookEdition tutun = new GoldenBookEdition("Tutun", "Dimitar Dimov", 22.90m);

           Console.WriteLine(podIgoto);
            Console.WriteLine();
            Console.WriteLine(tutun);
        }
    }
}
