using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
   public class IndividualCustomer : Customer
    {
       public IndividualCustomer(string name) : base(name)
       {
           this.Name = name;
       }
    }
}
