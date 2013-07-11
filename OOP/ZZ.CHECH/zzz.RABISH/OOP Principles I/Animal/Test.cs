using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Test
    {
        static void Main(string[] args)
        {
           Dog[] dogs =
            {
                new Dog("Pluto", 15, "male" ),
                new Dog("Gosho", 8, "male" ),
                new Dog("Balkan", 0.5, "male" ),
                new Dog("Stefka", 10, "female" ),
            };
           Console.WriteLine(Animal.AverageAge(dogs));

           Frog[] frogs =
            {
                new Frog("Jabcho", 2, "male" ),
                new Frog("Jabka", 1, "female" ),
                new Frog("Jabarka", 1.5, "female" ),
                new Frog("Jaboran", 3, "male" ),
            };
           Console.WriteLine(Animal.AverageAge(frogs));
        }
    }
}
