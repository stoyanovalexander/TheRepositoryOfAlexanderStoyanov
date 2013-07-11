using System;
using System.Collections.Generic;

namespace Bank
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            List<Account> listOfAccounts = new List<Account>(3);
            listOfAccounts.Add(new DepositAccount(new Customer("Bogdan Despotov", AccountTypes.individual), (decimal)5900.23, 0.1f));
            listOfAccounts.Add(new LoanAccount(new Customer("Arhangel Mihail", AccountTypes.individual), (decimal)3000, 0.2f));
            listOfAccounts.Add(new MortgageAccount(new Customer("Dan Kolov", AccountTypes.individual), (decimal)100000, 0.2f));
            foreach (Account account in listOfAccounts)
            {
                Console.WriteLine(account.ToString());
                Console.WriteLine();
                Console.WriteLine(account.CalculateIntrest(3));
                Console.WriteLine(account.CalculateIntrest(9));
                Console.WriteLine(account.CalculateIntrest(21));
                Console.WriteLine("*    *    *");
            }
        }
       
    }
}
