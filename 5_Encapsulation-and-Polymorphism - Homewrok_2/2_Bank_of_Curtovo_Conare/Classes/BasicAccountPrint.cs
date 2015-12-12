using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
    public class BasicAccountPrint : IFormatter
    {

        public string Format(Account account)
        {

            if (account.Balance < 0)
            {
                return string.Format($"{account.GetType().Name} >>>>> {Environment.NewLine}" +
                                $"Overdraft: {account.Balance}{Environment.NewLine}" +
                                $"Montly interest rate:  {account.MonthlyInterestRate} {Environment.NewLine}" +
                                $"Interest rate for 24 months:   {account.InterestRate(24)}{Environment.NewLine}");
            }
            
                return string.Format($"{account.GetType().Name} >>>>> {Environment.NewLine}" +
                                $"Balance: {account.Balance}{Environment.NewLine}" +
                                $"Montly interest rate:  {account.MonthlyInterestRate} {Environment.NewLine}" +
                                $"Interest rate for 24 months:   {account.InterestRate(24)}{Environment.NewLine}");
            

           
        }
    }
}
