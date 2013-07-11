using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Individual : Customer
    {
        private int age;
        private Sex sex;
        public Individual(int age, string name, Sex sex): base(name)
        {
            this.age = age;
        }
    }
}
