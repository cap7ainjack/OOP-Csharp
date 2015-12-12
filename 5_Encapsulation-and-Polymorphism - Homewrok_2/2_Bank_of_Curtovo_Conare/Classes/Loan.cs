using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Interfaces;

namespace _2_Bank_of_Curtovo_Conare.Classes
{
    public  class Loan : Account
    {
        public Loan(ICustomer customer, decimal balance, decimal montlyInterestRate)
            : base(customer, balance, montlyInterestRate)
        {

        }

        public override decimal InterestRate(double months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return months <= 3 ? this.Balance : base.InterestRate(months - 3);
            }

            return months <= 2 ? this.Balance : base.InterestRate(months - 2);
        }
    }
}
