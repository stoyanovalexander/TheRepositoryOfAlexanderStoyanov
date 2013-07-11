using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student : Human
    {
        private int _grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
            _grade = grade;
        }

        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
    }
}
