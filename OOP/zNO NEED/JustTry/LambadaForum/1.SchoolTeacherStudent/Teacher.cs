using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Teacher:People
    {
        public List<Discipline> Discplines { get; set; }
        public string Comment { get; set; }


        public Teacher(string name)
        {
            this.Discplines = new List<Discipline>();
            this.Name = name;
        }
    }
}
