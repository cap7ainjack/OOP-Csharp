using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCcatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Component vga = new Component("VGA", "Intel HD Graphics 4400", 256.6);
            Component vga2 = new Component("VGA", "Intel HD Graphics 5000", 306.6);
            Component ssd = new Component("SSD 250GB", "Samsung 850 EVO", 207.9);
            Component ssd2 = new Component("SSD 120GB", "A-Data Pro SP920", 114.64);
            Component ram = new Component("RAM", "Мноо бърза!", 199.89);
            Component cpu = new Component("Processor", "Intel Core i5", 399.52);
            Component cpu2 = new Component("Processor", "Intel Core i7", 499.02);
            Component kb = new Component("Keyboard", "Подарък!", 0);

            List<Computer> computers = new List<Computer>()
            {
                new Computer("Dell", cpu, ssd, kb),
                new Computer("Alienware", cpu2, ssd2, vga),
                new Computer("HP", ram, vga2, kb),
                new Computer("Apple", cpu, kb),
            };

            computers
                 .OrderBy(computer => computer.Price)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
