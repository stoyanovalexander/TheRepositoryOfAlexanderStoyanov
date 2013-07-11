using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Mortgage : Account
    {
        private int mortgagePeriod;
        public Mortgage(Customer customer, decimal balance, decimal interestRate, int mortgagePeriod)
            : base(customer, balance, interestRate, 0)
        {
            this.MortgagePeriod = mortgagePeriod;
        }
        public int MortgagePeriod
        {
            get
            {
                return this.mortgagePeriod;
            }
            set
            {
                this.mortgagePeriod = value;
            }
        }

        public override void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest()
        {
            if (this.mortgagePeriod<=12 && this.Customer is Company)
            {
                return (this.InterestRate * this.mortgagePeriod) / 2;
            }
            else if (this.mortgagePeriod <= 6 && this.Customer is Individual)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * this.MortgagePeriod;
            }
        

        }
    }
}
