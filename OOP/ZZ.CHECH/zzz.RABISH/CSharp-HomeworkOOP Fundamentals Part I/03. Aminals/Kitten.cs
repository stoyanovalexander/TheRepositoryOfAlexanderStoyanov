using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Aminals
{
    public class Kitten : Cat
    {
        //Constructor.
        public Kitten(string name, byte age)
            : base(name, age, Sex.Female)
        { 
        }
    }
}
