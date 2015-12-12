using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Exrcs_LOGGER
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            client.Name = "Pesho";
            client.Age = 22;

            var printer = new Printer();
            printer.Print(client,new StringBasicFormat());
        }
    }
}
