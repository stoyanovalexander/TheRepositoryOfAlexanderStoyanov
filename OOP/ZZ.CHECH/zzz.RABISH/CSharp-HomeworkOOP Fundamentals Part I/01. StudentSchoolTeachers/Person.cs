using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_HomeworkOOP_Fundamentals_Part_I
{
    public class Person
    {
        //Fields.
        private string name;

        //Constructors.
        public Person()
        { }
        public Person(string name)
        {
            this.name = name;
        }

        //Properties.
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a string!!!");
                }
            }
        }
    }
}
