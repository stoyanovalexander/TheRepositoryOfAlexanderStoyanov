using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Student:People
    {
        private string name;
        private int classNumber;
        private Coment coments;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }

        public Student(string name, int classNumber, Coment coments)
        {
            this.name = name;
            this.classNumber = classNumber;
            this.coments = coments;
        }
        public Student(string name, int classNumber)
        {
            this.name = name;
            this.classNumber = classNumber;
        }
    }
}
