using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Aminals
{
    public class Tomcat : Cat
    {
        //Constructor.
        public Tomcat(string name, byte age)
            : base(name, age, Sex.Male)
        { 
        }
    }
}
