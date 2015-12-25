using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.IO
{
    using Contracts;
   public class ConsoleReader : IReader
    {
       public string ReadLine()
       {
            var input = Console.ReadLine();

            return input;
        }
    }
}
