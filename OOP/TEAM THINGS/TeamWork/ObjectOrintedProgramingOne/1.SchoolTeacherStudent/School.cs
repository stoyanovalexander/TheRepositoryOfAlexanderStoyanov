using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class School
    {
        private string name;

        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }

        public School(string name)
        {
            this.name = name;
        }
    }
}
