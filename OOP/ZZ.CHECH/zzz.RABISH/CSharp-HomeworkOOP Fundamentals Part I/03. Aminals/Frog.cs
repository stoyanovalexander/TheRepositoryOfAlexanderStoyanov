using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Aminals
{
    public class Frog : Animal, ISound
    {
        //Constructor
        public Frog(string name, byte age, Sex sex)
            : base(name, age, sex)
        { 
        }

        //Methods.
        public void ProduceSound()
        {
            Console.WriteLine("Hello! I'm {0} and I say QWACK!!!", this.Name);
        }
    }
}
