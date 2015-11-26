using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Football_League.Models;

namespace Lab_Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "End" && line != null)
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}
