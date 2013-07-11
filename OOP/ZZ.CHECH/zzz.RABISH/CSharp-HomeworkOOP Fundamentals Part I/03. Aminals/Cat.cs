using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Aminals
{
    public class Cat : Animal, ISound
    {
        //Constructor.
        public Cat(string name, byte age, Sex sex)
            : base(name, age, sex)
        { 
        
        }

        //Methods.
        public void ProduceSound()
        {
            Console.WriteLine("Hello! I'm {0} and I say MIAUUU!!!", this.Name);
        }
    }
}
