using System;

namespace Bank
{
    abstract class Account
    {
        #region Fields
        
        private Customer customer;
        private decimal balance;
        private float intrest;
        
        #endregion
        
        #region Properties
        
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set
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
            protected set
            {
                this.balance = value;
            }
        }
        
        public float Intrest
        {
            get
            {
                return this.intrest;
            }
            protected set
            {
                this.intrest = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Account(Customer customer, decimal balance, float intrest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Intrest = intrest;
        }
        
        #endregion
        
        #region Methods

        public virtual decimal Deposit(decimal amount)
        {
            this.Balance += amount;
            return this.balance;
        }

        public virtual decimal Withdraw(decimal amount)
        {
            this.Balance -= amount;
            return this.balance;
        }
        
        public abstract decimal CalculateIntrest(int period);
        public override string ToString()
        {
            return string.Format("Account Type: {0}\nCustomer name: {1}\nCustomer type: {2}\nBalance: {3:0.00}\nIntrest Rate: {4:0%}", this.GetType(), this.Customer.Name, this.Customer.Type, this.Balance, this.Intrest);
        }
        #endregion
    }
}