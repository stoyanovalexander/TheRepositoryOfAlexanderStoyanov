using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class Mortgage : Acount
    {
        public Mortgage(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate) { }

        // Methods
        public override double CalculateInterestAmount(int months)
        {
            if (this.Customer.GetType().Name == "IndividualCustomer")
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 6);
                }
            }
            else //if (this.Customer.GetType().Name == "CompanyCustomer")
            {
                if (months <= 12)
                {
                    return base.CalculateInterestAmount(months) / 2;
                }
                else
                {
                    return base.CalculateInterestAmount(months - 12)
                        + base.CalculateInterestAmount(12) / 2;
                }
            }
        }
    }
}
