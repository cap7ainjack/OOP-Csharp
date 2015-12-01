using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheetah che = new Cheetah(2);
            Console.WriteLine(che.CalculateDistance(2) + "km");

        }
    }
}
