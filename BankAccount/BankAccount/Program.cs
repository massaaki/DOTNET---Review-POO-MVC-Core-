using System;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount bAcc = new BusinessAccount(5621, "Some Name Business", 10000.00, 50000.00);
            Account acc = new Account(8031, "Some Name 02", 0.0) ;


            //Upcasting sample
            Account acc1 = bAcc;
            Account acc2 = new BusinessAccount(3231, "Some Name 03", 321.3, 20000);
            Account acc3 = new SavingsAccount(1854, "Some name 05", 0.0, 0.02);

            
            //Donwcasting sample
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(340);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount) //Must do this to validate right object
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }


            if(acc2 is BusinessAccount)
            {
                BusinessAccount acc6 = acc2 as BusinessAccount;
            }
          
        }
    }
}
