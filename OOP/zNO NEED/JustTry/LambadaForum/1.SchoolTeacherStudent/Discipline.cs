using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Discipline
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }

        public Discipline(string Name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = Name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }
    }
}
