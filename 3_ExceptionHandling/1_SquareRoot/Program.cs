using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n = int.Parse(Console.ReadLine());
                string output;

                output = n < 0 ? "Invalid number. Number must be positive"
                        : $"Square root of {n} is {Math.Sqrt(n)}";
                Console.WriteLine(output);

                //if (n < 0)
                //{
                //    Console.WriteLine("Invalid number. Number must be positive");
                //}
                //else
                //{
                //    Console.WriteLine($"Square root of {n} is {Math.Sqrt(n)}");
                //}

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }

            finally
            {
               Console.WriteLine("Good Bye");
            }
        }
    }
}
