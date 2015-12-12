using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
   public abstract class Customer : ICustomer
   {
     //  private string name;

       protected Customer(string name)
       {
           this.Name = name;
       }

        public string Name { get; set; }



   }
}
