using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentsInCoursesSort
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Discipline { get; set; }

        public Student(string firstName, string lastName, string discipline)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Discipline = discipline;
        }
    }
}
