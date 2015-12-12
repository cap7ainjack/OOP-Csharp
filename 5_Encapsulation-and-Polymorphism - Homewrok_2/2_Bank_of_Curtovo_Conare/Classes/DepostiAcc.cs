using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
   public class DepostiAcc : Account, IWithdrawable
    {
       public DepostiAcc(ICustomer customer, decimal balance, decimal montlyInterestRate) : base(customer, balance, montlyInterestRate)
       {

       }

       public override decimal InterestRate(double months)
       {
           if (this.Balance < 1000  && this.Balance >= 0)
           {
               return this.Balance;
           }

           return base.InterestRate(months);
       }


       public void Withdraw(decimal amount)
       {
           this.Balance -= amount;
       }
    }
}
