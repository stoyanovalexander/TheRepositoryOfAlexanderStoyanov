using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Teacher:People
    {
        private List<Discipline> teacherDisciplines;
        private string name;
        private Coment coments;

        public List<Discipline> TeacherDisciplines
        {
            get { return this.teacherDisciplines; }
            set { this.teacherDisciplines = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Coment Coments
        {
            get { return this.coments; }
            set { this.coments = value; }
        }
     
        public Teacher(string name, List<Discipline> teacherDisciplines, Coment coments)
        {
            this.name = name;
            this.teacherDisciplines = teacherDisciplines;
            this.coments = coments;
        }
        public Teacher(string name, List<Discipline> teacherDisciplines)
        {
            this.name = name;
            this.teacherDisciplines = teacherDisciplines;
        }
    }
}
