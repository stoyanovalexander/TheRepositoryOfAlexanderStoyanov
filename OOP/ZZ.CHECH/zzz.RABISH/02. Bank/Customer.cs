using System;

namespace Bank
{
    class Customer
    {
        private string name;
        private AccountTypes type;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public AccountTypes Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public Customer(string name, AccountTypes type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}
