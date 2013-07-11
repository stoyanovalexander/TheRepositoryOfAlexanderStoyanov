using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class Customer
    {
        public string Name;
        public string PhoneNumber;

        //private string name;
        //private string phoneNumber;

        // Constructors
        //public Customer()
        //    : this(string.Empty, string.Empty) { }

        public Customer(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        // Properties
        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //public string PhoneNumber
        //{
        //    get { return this.phoneNumber; }
        //    set { this.phoneNumber = value; }
        //}
    }
}
