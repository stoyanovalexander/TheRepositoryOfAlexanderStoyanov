using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalDogFrogCat
{
    class TestAnimalDogFrogCat
    {
        static void Main(string[] args)
        {
            Frog[] frogs =
            {
                new Frog( 2, "Frog1", 'f'),
                new Frog( 8, "Frog2", 'f'),
                new Frog( 6, "Frog3", 'f'),
                new Frog( 7, "Frog4", 'f')
            };
            Dog[] dogs =
            {
                new Dog( 4, "Dog1", 'f'),
                new Dog( 7, "Dog2", 'f'),
                new Dog( 8, "Dog3", 'f'),
                new Dog( 10, "Dog4", 'f')
            };
            Cat[] cats =
            {
                new Kitten( 3, "Cat1"),
                new TomCat( 5, "Cat2"),
                new Kitten( 2, "Cat3"),
                new TomCat( 1, "Cat4")
            };

            dogs[2].IdentifyAnimal();
            cats[1].IdentifyAnimal();
            frogs[3].ProduceSound();

            Console.WriteLine("Average age of dogs " + Animal.Average(dogs));
            Console.WriteLine("Average age of frogs " + Animal.Average(frogs));
            Console.WriteLine("Average age of cats " + Animal.Average(cats));

        }
    }
}
