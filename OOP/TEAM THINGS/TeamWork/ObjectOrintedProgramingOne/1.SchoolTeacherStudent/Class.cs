using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Class
    {
        private List<Teacher> classTeachers;
        private List<Student> classStudents;
        private string textIdentifier;
        private Coment coments;

        public List<Teacher> ClassTeachers
        {
            get { return this.classTeachers; }
            set { this.classTeachers = value; }
        }
        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set { this.textIdentifier = value; }
        }
        public List<Student> ClassStudents
        {
            get { return this.classStudents; }
            set { this.classStudents = value; }
        }

        public Class(List<Teacher> classTeachers, List<Student> classStudents, string textIdentifier, Coment coments)
        {
            this.classTeachers = classTeachers;
            this.classStudents = classStudents;
            this.textIdentifier = textIdentifier;
            this.coments = coments;
        }

        public Class(List<Teacher> classTeachers, List<Student> classStudents, string textIdentifier)
        {

            this.classStudents = classStudents;
            this.classTeachers = classTeachers;
            this.textIdentifier = textIdentifier;
        }

    }
}
