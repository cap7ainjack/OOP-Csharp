using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Bank_of_Curtovo_Conare.Classes;

namespace _2_Bank_of_Curtovo_Conare
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new IndividualCustomer("Piotr Mihajlovic");
            var customer2 = new CompanyCustomer("Adis OOD");
            

            var depositAccount = new DepostiAcc(customer1, 2000.0m,2.3m);
            var depositAcc = new DepostiAcc(customer2, 200000.0m, 7.8m);

            var loanAcc = new Loan(customer1, 2000.0m, 13.6m);
            var loanAccount = new Loan(customer2, 200000.0m, 6.6m);

            var mortgageAcc = new Mortgage(customer1, 2000.0m, 11.2m);
            var mortgageAccount = new Mortgage(customer2, 200000.0m, 5.1m);



            var printer = new Printer();
            printer.Print(depositAccount, new BasicAccountPrint());

            depositAccount.Withdraw(5000.0m);

            printer.Print(depositAccount, new BasicAccountPrint());

        }
    }
}
