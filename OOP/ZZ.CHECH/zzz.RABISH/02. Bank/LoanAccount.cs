using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, float intrest)
            : base(customer, balance, intrest)
        { 
        }

        public override decimal Withdraw(decimal amount)
        {
            Console.WriteLine("Cannot withrow from a loan account!");
            return this.Balance;
        }
        public override decimal CalculateIntrest(int period)
        {
            if (period <= 3)
            {
                Console.WriteLine("No intrest for the first 3 months.");
                return 0;
            }
            else
            {
                return ((decimal)this.Intrest * (decimal)(period - 3));
            }
        }
    }
}