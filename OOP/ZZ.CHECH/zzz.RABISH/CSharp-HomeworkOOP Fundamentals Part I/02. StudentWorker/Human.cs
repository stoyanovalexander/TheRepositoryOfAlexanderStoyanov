using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.StudentWorker
{
    public class Human
    {
        //Fields.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor.
        public Human()
        { 
        
        }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
