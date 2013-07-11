using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentWorker
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        //Constructor
        public Student(int grade, string firstName, string lastName)
            : base(firstName, lastName) 
        {
            this.Grade = grade;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}