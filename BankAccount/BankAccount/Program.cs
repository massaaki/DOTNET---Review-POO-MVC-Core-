using System;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(5621, "Some Name", 10000.00, 50000.00);

            Console.WriteLine(account.Balance);
          
        }
    }
}
