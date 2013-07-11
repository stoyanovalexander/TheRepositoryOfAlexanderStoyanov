using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class IndividualCustomer : Customer
    {
        // Fields
        private string egn;
        public IndividualCustomer(string name, string phoneNumber, string egn)
            : base(name, phoneNumber)
        {
            this.egn = egn;
        }

        public string EGN
        {
            get { return this.egn; }

            protected set { this.egn = value; }
        }
    }
}
