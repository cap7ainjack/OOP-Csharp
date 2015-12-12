using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
   public class CompanyCustomer : Customer
    {
       public CompanyCustomer(string name) : base(name)
       {
           this.Name = name;
       }
    }
}
