using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Company : Customer
    {
        private string bulstat;
        public Company(string name, string bulstat)
            : base(name)
        {
            this.Bulstat = bulstat;
        }
        public string Bulstat
        {
            get
            {
                return this.bulstat;
            }
            set
            {
                this.bulstat = value;
            }
        }
    }
}
