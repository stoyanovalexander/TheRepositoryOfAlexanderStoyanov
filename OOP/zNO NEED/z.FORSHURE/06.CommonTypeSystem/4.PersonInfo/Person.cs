using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonInfo
{
    public class Person
    {
        private string name;
        private int? age; 

        public string Name
        {
            get { return this.name; }
            set
            { this.name = value; }
        }

        public int? Age 
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string someName, int? someAge) 
        {
            this.Name = someName;
            this.Age = someAge;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}",
                this.Name, this.Age != null ? this.Age.ToString() : "Undefined");
        }
    }
}
