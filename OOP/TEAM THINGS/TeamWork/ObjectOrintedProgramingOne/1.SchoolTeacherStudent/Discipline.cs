using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Discipline
    {
        private string name;
        private int numOfLectores;
        private int numOfExercises;
        private Coment coments;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int NumOfLectures
        {
            get { return this.numOfLectores; }
            set { this.numOfLectores = value; }
        }
        public int NumOfExercises
        {
            get { return this.numOfExercises; }
            set { this.numOfExercises = value; }
        }
        public Discipline(string name, int numOfLectores, int numOfExcercisess, Coment coments)
        {
            this.name = name;
            this.numOfLectores = numOfLectores;
            this.numOfExercises =numOfExcercisess ;
            this.coments = coments;
        }

        public Discipline(string name, int numOfLectores, int numOfExcercisess)
        {
            this.name = name;
            this.numOfLectores = numOfLectores;
            this.numOfExercises = numOfExcercisess;
        }
    }
}
