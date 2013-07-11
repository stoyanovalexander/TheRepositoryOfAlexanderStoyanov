using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class CompanyCustomer : Customer
    {
        // Fields
        private string acountantName;

        public CompanyCustomer(string name, string phoneNumber, string acountantName)
            : base(name, phoneNumber)
        {
            this.acountantName = acountantName;
        }

        public string AcountantName
        {
            get { return this.acountantName; }
            set { this.acountantName = value; }
        }
    }
}
