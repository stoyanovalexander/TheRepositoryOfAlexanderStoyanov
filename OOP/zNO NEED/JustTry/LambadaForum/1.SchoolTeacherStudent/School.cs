using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class School
    {
        public string Name { get; set; }
        List<School> classes;

        public School(string schoolName)
        {
            this.classes = new List<School>();
            this.Name = schoolName;
        }
    }
}
