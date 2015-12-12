using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
   public class Mortgage : Account
    {
       public Mortgage(ICustomer customer, decimal balance, decimal montlyInterestRate) : base(customer, balance, montlyInterestRate)
       {
       }

       public override decimal InterestRate(double months)
       {
           if (Customer is IndividualCustomer)
           {
               return months <= 6 ? this.Balance : base.InterestRate(months - 6);
           }

           return months > 12
               ? base.InterestRate(12/2) + base.InterestRate(months - 12)
               : base.InterestRate(months/2);
       }
    }
}
 