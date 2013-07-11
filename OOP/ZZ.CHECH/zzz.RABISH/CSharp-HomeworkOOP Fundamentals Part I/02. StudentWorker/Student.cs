using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.StudentWorker
{
    public class Student : Human
    {
        //Fields.
        public byte Grade { get; set; }

        //Constructor.
        public Student()
        { }
        public Student(string firstName, string lastName, byte grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}
