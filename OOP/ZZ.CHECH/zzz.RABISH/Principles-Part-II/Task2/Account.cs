using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private int numberOfMonths;


        public Account(Customer customer, decimal balance ) :this(customer,  balance, 0, 0)
        {
        }

        public Account(Customer customer, decimal balance, decimal interestRate, int month)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.NumberOfMonths = numberOfMonths;
        }

        public int NumberOfMonths
        {
            get
            {
                return this.numberOfMonths;
            }
            set
            {
                this.numberOfMonths = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public virtual void DepositMoney(decimal amount)
        {
        }
        public virtual void WithDraw(decimal amount)
        {
        }

        public virtual decimal CalculateInterest()
        {
            return this.NumberOfMonths * this.InterestRate;
        }
    }
}
