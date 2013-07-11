using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Dog : Animal
    {
        public Dog(string name, double age, string sex)
            : base(name, age, sex) { }
         public void ProduceSound()
         {
             Console.WriteLine(Name + " " + "Bau");
         }
    }
}
