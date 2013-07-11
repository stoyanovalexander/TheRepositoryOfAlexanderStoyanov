using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Loan : Account
    {
        private int loanPeriod;
        public Loan(Customer customer, decimal balance, decimal interestRate, int loanPeriod)
            : base(customer, balance, interestRate, 0)
        {
            this.LoanPeriod = loanPeriod;
        }
        public int LoanPeriod
        {
            get
            {
                return this.loanPeriod;
            }
            set
            {
                this.loanPeriod = value;
            }
        }

        public override void DepositMoney(decimal amount)
        {
             this.Balance += amount;
        }

        public override decimal CalculateInterest()
        {
            if (this.LoanPeriod<=3 && Customer is Individual)
            {
                return 0;
            }
            else if (this.LoanPeriod <= 2 && Customer is Company)
            {
                return 0;
            }
            else
            {
                return this.LoanPeriod * this.InterestRate;
            }
        
        }
    }
}
