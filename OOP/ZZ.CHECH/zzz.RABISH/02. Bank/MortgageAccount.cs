using System;

namespace Bank
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, float intrest) : base(customer,balance, intrest)
        { 
        }

        public override decimal Withdraw(decimal amount)
        {
            Console.WriteLine("You cannot withraw money form mortgage account.");
            return 0;
        }

        public override decimal CalculateIntrest(int period)
        {
            if (this.Customer.Type == AccountTypes.individual)
            {
                if (period <= 6)
                {
                    return 0;
                }
                else
                {
                    return ((decimal)this.Intrest * (decimal)(period - 6));
                }
            }
            else
            {
                if (period <= 12)
                {
                    return ((decimal)this.Intrest * (decimal)period * (decimal)0.5);
                }
                else
                {
                    return ((decimal)this.Intrest * (decimal)(period - 12)) + ((decimal)this.Intrest * (decimal)12 * (decimal)0.5);
                }
            }
        }

        
    }
}