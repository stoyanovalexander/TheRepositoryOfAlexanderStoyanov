using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Aminals
{
    public class Dog : Animal, ISound
    {
        //Constructor.
        public Dog(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
        }

        //Methods.
        public void ProduceSound()
        {
            Console.WriteLine("Hello! I'm {0} and I say BAU BAU!!!", this.Name);
        }
    }
}
