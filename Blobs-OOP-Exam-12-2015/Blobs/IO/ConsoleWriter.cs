using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.IO
{
    using Contracts;
   public class ConsoleWriter : IWriter
    {
       public void Print(string message)
       {
            Console.WriteLine(message);
        }
    }
}
