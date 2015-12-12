using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
   public abstract class Account : IAccount, IDepositable
   {
      // private ICustomer customer;
      // private decimal balance;
      // private decimal montlyInterestRate;

       protected Account(ICustomer customer, decimal balance, decimal montlyInterestRate)
       {
           this.Customer = customer;
           this.Balance = balance;
           this.MonthlyInterestRate = montlyInterestRate;
       }

       public ICustomer Customer { get; set; }
       public decimal Balance { get; protected set; }
       public decimal MonthlyInterestRate { get; protected set; }

        public virtual decimal InterestRate(double months)
       {
           return this.Balance * (1 + this.MonthlyInterestRate* (decimal)months);
       }

       public void Deposit(decimal amount)
       {
           this.Balance += amount;
       }
   }
}
