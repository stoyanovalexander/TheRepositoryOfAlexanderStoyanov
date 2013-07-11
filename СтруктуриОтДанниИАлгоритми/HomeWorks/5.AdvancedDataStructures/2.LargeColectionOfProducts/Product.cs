using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Product : IComparable<Product>
    {
        double price;
        string name;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be more than zero!");
                }
                this.price = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
                this.name = value;
            }
        }

        public int CompareTo(Product otherProduct)
        {
            if (this.price < otherProduct.Price)
            {
                return 1;
            }
            if (this.price > otherProduct.price)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
