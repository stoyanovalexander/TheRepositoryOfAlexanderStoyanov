using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    abstract class Acount :  IDeposit, IPrintable, IInterest
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Acount(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        // Properties
        public Customer Customer
        {
            get { return this.customer; }
            protected set
            { this.customer = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            protected set
            { this.balance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            protected set
            { this.interestRate = value; }
        }

        // Methods
        public virtual double CalculateInterestAmount(int months)  
        {
            return months * this.interestRate * this.balance; 
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0},  {1},  Balance: {2},  Interest rate: {3}",
                this.GetType().Name, customer.Name, this.balance, this.interestRate);
        }
    }
}
