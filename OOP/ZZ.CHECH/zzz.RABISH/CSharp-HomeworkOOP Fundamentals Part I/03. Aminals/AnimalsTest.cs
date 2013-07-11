using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Aminals
{
    class AnimalsTest
    {
        static void Main()
        {
            //List of Dogs.
            List<Animal> dogList = new List<Animal> 
            {
                new Dog("Rex", 5, Sex.Male),
                new Dog("Roxy", 3, Sex.Female),
                new Dog("Pipi", 7, Sex.Female),
                new Dog("Balkan", 8, Sex.Male),
                new Dog("Tinka", 5, Sex.Female),
                new Dog("Vihyr", 5, Sex.Male)
            };

            //List of Frogs.
            List<Animal> frogList = new List<Animal> 
            {
                new Frog("Kvachko", 2, Sex.Male),
                new Frog("Curmit", 6, Sex.Male),
                new Frog("Jabka", 3, Sex.Female),
                new Frog("Rico", 1, Sex.Male),
                new Frog("Antonia", 3, Sex.Female),
                new Frog("Rexyc", 4, Sex.Male),
            };

            //List of Cats.
            List<Animal> catList = new List<Animal> 
            { 
                new Kitten("Missy", 3),
                new Tomcat("Tom", 4),
                new Kitten("Kukla", 2),
                new Tomcat("Timothy", 5),
                new Kitten("Mariyka", 1),
                new Tomcat("Diego", 3)
            };

            Console.WriteLine("========= Introduce ==========\n");
            //Intrduce animals.
            catList[2].IntroduceAnimal();
            frogList[1].IntroduceAnimal();
            dogList[4].IntroduceAnimal();
            catList[0].IntroduceAnimal();

            Console.WriteLine();
            Console.WriteLine("========= Average =========\n");

            //Get average age of animals.
            Console.WriteLine("Average age of dogs: {0}", Animal.GetAverageAnimalAge(dogList));
            Console.WriteLine("Average age of frogs: {0}",  Animal.GetAverageAnimalAge(frogList));
            Console.WriteLine("Average age of cats: {0}",  Animal.GetAverageAnimalAge(catList));
        }
    }
}
