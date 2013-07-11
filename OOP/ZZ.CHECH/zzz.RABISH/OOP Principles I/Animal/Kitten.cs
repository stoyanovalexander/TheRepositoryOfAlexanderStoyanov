using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Kitten : Cat
    {
        const string _SEX = "female";
        public Kitten(string name, double age)
            : base(name, age, _SEX) { }

    }
}
