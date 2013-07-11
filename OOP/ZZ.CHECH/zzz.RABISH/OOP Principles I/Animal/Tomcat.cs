using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Tomcat : Cat
    {
        const string _SEX = "male";
        public Tomcat(string name, double age)
            : base(name, age, _SEX) { }
    }
}
