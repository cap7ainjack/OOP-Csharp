using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
    public class Printer
    {

        public void Print(Account account, BasicAccountPrint formatter)
        {
            var result = formatter.Format(account);

            Console.WriteLine(result);
        }
    }
}
