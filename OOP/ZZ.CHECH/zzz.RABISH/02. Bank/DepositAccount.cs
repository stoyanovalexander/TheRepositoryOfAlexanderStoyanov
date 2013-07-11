using System;

namespace Bank
{
    class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, float intrest) : base(customer, balance, intrest)
        {
        }

        private decimal IntrestCalculation(int period)
        {
            return (decimal)period * (decimal)this.Intrest;
        }

        public override decimal CalculateIntrest(int period)
        {
            if (this.Balance < 0)
            {
                return -IntrestCalculation(period);
            }
            else if (this.Balance > 1000)
            {
                return IntrestCalculation(period);
            }
            else
            {
                return 0;
            }
        }
    }
}