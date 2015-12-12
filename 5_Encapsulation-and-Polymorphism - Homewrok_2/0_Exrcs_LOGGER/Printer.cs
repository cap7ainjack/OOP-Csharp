using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Exrcs_LOGGER
{
    class Printer
    {
        public void Print(Client client, IFormatter formatter)
        {
    
           var result = formatter.Format(client);

            Console.WriteLine(result);

            // class Print does nto suit format strings, so to keep OOP principles
            // we create StringBasicFormat - a class only to format string when we need it
        }
    }
}
