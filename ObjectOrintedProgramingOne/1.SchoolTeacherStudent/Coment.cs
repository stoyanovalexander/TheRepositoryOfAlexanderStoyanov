using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class Coment
    {
        private List<string> someComents;

        public List<string> SomeComents
        {
            get { return this.someComents; }
            set { this.someComents = value; }
        }
        public Coment(List<string> someComents)
        {}
    }
}
