using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class Deposit : Acount, IWithDraw
    {
        public Deposit(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate) { }

        // Method1
        public override double CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(months);
            }
        }
        //Method2
        public void WithDraw(double amount)
        {
            if (this.Balance < amount)
            {
                throw new ArgumentException("Sory you do not have so much money in your deposit!");
            }
            else
            {

                 this.Balance = this.Balance - amount;
               
            }
        }
    }
}
