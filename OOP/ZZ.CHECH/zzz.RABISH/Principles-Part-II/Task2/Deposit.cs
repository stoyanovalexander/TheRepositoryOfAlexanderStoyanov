using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Deposit : Account, IWithDrawable
    {
        private int depositPeriod;

        public Deposit(Customer customer, decimal balance, decimal interestRate,int depositPeriod)
            : base(customer, balance, interestRate, 0)
        {
            this.depositPeriod = depositPeriod;
        }

        public int DepositPeriod
        {
            get
            {
                return this.depositPeriod;
            }
            set
            {
                this.depositPeriod = value;
            }
        }

        public override void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override void WithDraw(decimal amount)
        {
            if (this.Balance > amount)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new Exception("Not enought money in the account");
            }
        }
        public override decimal CalculateInterest()
        {
            if (this.Balance<=1000)
            {
                return 0;
            }
            else
            {
                return this.DepositPeriod * this.InterestRate;
            }
        
        }
    }
}
