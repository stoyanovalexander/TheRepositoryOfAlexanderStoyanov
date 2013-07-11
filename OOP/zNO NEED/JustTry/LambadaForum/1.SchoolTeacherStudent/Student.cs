using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Student:People
    {
        public string ClassNumber { get; set; }

        public string Comment { get; set; }

        public Student(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }
    }
}
