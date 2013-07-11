using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class Loan : Acount
    {
        public Loan(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate) { }

        // Methods
        public override double CalculateInterestAmount(int months)
        {
            if (this.Customer.GetType().Name == "IndividualCustomer")
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 3);
                }
            }
            else //if (this.Customer.GetType().Name == "CompanyCustomer")
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 2);
                }
            }
        }
    }
}
