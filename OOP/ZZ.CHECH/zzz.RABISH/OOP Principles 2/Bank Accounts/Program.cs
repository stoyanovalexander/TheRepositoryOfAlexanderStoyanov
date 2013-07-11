using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank_Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("BulBank");

            Individual i = new Individual("Peshko");
            Company c = new Company("Indezid");

            LoanAccount l1 = new LoanAccount(i, 300, 120);
            LoanAccount l2 = new LoanAccount(c, 300, 120);

            DepositAccount d1 = new DepositAccount(i, 1500, 120);
            DepositAccount d2 = new DepositAccount(c, 500, 120);

            MortrageAccount m1 = new MortrageAccount(i, 500, 120);
            MortrageAccount m2 = new MortrageAccount(c, 500, 120);

            List<Accounts> acc = new List<Accounts>();
            acc.Add(l1);
            acc.Add(l2);
            acc.Add(d1);
            acc.Add(d2);
            acc.Add(m1);
            acc.Add(m2);

            bank.Acc = acc;

            foreach (Accounts a in bank.Acc)
            {
                Console.WriteLine("Interest amount by accounts: {0} ",a.InterestAmount(17));
            }

        }
    }

    /// <summary>
    /// Class Bank
    /// </summary>
    public class Bank
    {
        private string Name;

        List<Accounts> acc = new List<Accounts>();

        /// <summary>
        /// Property list Account
        /// </summary>
        public List<Accounts> Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        /// <summary>
        /// Constructor for the Bank class
        /// </summary>
        /// <param name="name"> bank name</param>
        public Bank(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// An abstract class Account
    /// </summary>
    public abstract class Accounts
    {
        /// <summary>
        /// Method for depositing money from account
        /// </summary>
        /// <param name="money">amount of money</param>
        /// <returns>A text indicating a successful deposit</returns>
        public abstract string Deposit(double money);

        /// <summary>
        /// Method for calculating an interest amount
        /// </summary>
        /// <param name="months">amount of money</param>
        /// <returns>The amount of interest</returns>
        public abstract double InterestAmount(int months);
    }

    /// <summary>
    /// Class LoanAccount - inheriting Accounts
    /// </summary>
    public class LoanAccount : Accounts
    {
        private Customer cust;
        private double balance;
        private double interestRate;

        /// <summary>
        /// Constructor for the class LoanAccount
        /// </summary>
        /// <param name="Cust">A customer object</param>
        /// <param name="Balance">An account balance</param>
        /// <param name="InterestRate">A value interest rate</param>
        public LoanAccount(Customer Cust, double Balance, double InterestRate)
        {
            cust = Cust;
            balance = Balance;
            interestRate = InterestRate;
        }

        /// <summary>
        /// Method Deposit - for depositing money
        /// </summary>
        /// <param name="money">money for depositing</param>
        /// <returns>a text indicating the successful deposit</returns>
        public override string Deposit(double money)
        {
            balance += money;

            return "Money deposited successfully";
        }

        /// <summary>
        /// Method for returning interest amount
        /// </summary>
        /// <param name="months">number of months</param>
        /// <returns>the amount of interest</returns>
        public override double InterestAmount(int months)
        {
            if (cust is Individual)
            {
                return interestRate * (months - 3);
            }
            else
            {
                return interestRate * (months - 2);
            }
        }
    }

    /// <summary>
    /// Class DepositAccount - inheriting Accounts
    /// </summary>
    public class DepositAccount : Accounts
    {
        private Customer cust;
        private double balance;
        private double interestRate;

        /// <summary>
        /// Constructor for the class DepositAccount
        /// </summary>
        /// <param name="Cust">A customer object</param>
        /// <param name="Balance">Account balance</param>
        /// <param name="InterestRate">Interest rate</param>
        public DepositAccount(Customer Cust, double Balance, double InterestRate)
        {
            cust = Cust;
            balance = Balance;
            interestRate = InterestRate;
        }

        /// <summary>
        /// Method for depositing money
        /// </summary>
        /// <param name="money">money to deposit</param>
        /// <returns>A text indicating successful deposit</returns>
        public override string Deposit(double money)
        {
            balance += money;

            return "Money deposited successfully";
        }

        /// <summary>
        /// Method for withdrawing money
        /// </summary>
        /// <param name="money">money to withdraw</param>
        /// <returns>A text indicating successful withdraw</returns>
        public string Withdraw(double money)
        {
            if (money <= balance)
            {
                balance -= money;

                return "Money deposited successfully";
            }
            else
            {
                return "Balance is less than the money to withdraw";
            }
        }

        /// <summary>
        /// Method for calculating interest amount
        /// </summary>
        /// <param name="months">number of months</param>
        /// <returns>the interest amount</returns>
        public override double InterestAmount(int months)
        {
            if (balance > 0 && balance < 1000)
            {
                return 0;
            }
            else
            {
                return interestRate * months;
            }
        }
    }

    /// <summary>
    /// Class MortrageAccount - inheriting Accounts
    /// </summary>
    public class MortrageAccount : Accounts
    {
        private Customer cust;
        private double balance;
        private double interestRate;

        /// <summary>
        /// Constructor for the class MortrageAccount
        /// </summary>
        /// <param name="Cust">A customer object</param>
        /// <param name="Balance">Account balance</param>
        /// <param name="InterestRate">Interest Rate</param>
        public MortrageAccount(Customer Cust, double Balance, double InterestRate)
        {
            cust = Cust;
            balance = Balance;
            interestRate = InterestRate;
        }

        /// <summary>
        /// Method for depositing money
        /// </summary>
        /// <param name="money">money for depositing</param>
        /// <returns>A text for indicating successful deposit</returns>
        public override string Deposit(double money)
        {
            balance += money;

            return "Money deposited successfully";
        }

        /// <summary>
        /// Method for calculating an interest amount
        /// </summary>
        /// <param name="months">number of months</param>
        /// <returns>the interest amount</returns>
        public override double InterestAmount(int months)
        {
            if (cust is Individual)
            {
                return (interestRate * 6) + (interestRate*(months-12));
            }
            else
            {
                return interestRate * (months - 6);
            }
        }
    }

    /// <summary>
    /// Class Customer
    /// </summary>
    public class Customer
    {
        private string name;

        /// <summary>
        /// Constructor for the class Customer
        /// </summary>
        /// <param name="Name">customer name</param>
        public Customer(string Name)
        {
            name = Name;
        }
    }

    /// <summary>
    /// Class Individual - inheriting Customer
    /// </summary>
    public class Individual:Customer
    {
        private string name;

        /// <summary>
        /// Constructor for the class Individual
        /// </summary>
        /// <param name="Name">individual name</param>
        public Individual(string Name):base(Name)
        {
            name = Name;
        }
    }

    /// <summary>
    /// Class Company - inheriting Customer
    /// </summary>
    public class Company:Customer
    {
        private string name;

        /// <summary>
        /// Constructor for the class Company
        /// </summary>
        /// <param name="Name">company name</param>
        public Company(string Name):base(Name)
        {
            name = Name;
        }
    }
}
