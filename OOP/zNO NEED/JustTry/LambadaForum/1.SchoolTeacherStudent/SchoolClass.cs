using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class SchoolClass
    {
        List<Teacher> teachers;
        List<Student> students;
        public string ClassID { get; set; }

        public string Comment { get; set; }

        public SchoolClass(string ClassID)
        {
            this.ClassID = ClassID;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }
    }
}
