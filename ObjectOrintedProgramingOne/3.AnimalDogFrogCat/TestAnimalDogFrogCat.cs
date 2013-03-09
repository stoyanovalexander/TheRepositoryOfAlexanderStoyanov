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
            Cat[] myCats=
            {
                new Cat(1,"Totcho","male"),
                new Cat(2,"Maca","female"),
                new Cat(1,"Puhcho","male")
            };
            Console.WriteLine("my cats overage is: {0}", Animal.Average(myCats));
            Dog[] myDogs=
            {
                new Dog(2,"Mecho","male"),
                new Dog(3,"Sharo","male"),
                new Dog(4,"Mecho","male")
            };
            Console.WriteLine("my dogs overage is: {0}",Animal.Average(myDogs));
            Frog[] myFrogs =
            {
                new Frog(1,"Malcho","male"),
                new Frog(1,"Gencho","male"),
                new Frog(1,"Pencho","male")
            };
            Console.WriteLine("my frogs overage is: {0}", Animal.Average(myFrogs));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ANIMALS SOUNDS");
            myCats[0].MakeSound();
            myDogs[0].MakeSound();
            myFrogs[0].MakeSound();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TOM CAT");
            TomCat topurko = new TomCat(1, "Topurko");
            topurko.MakeSound();
            Console.WriteLine(topurko.Sex);
            Console.WriteLine();
            Console.WriteLine();
            Kitten milka = new Kitten(2, "milka");
            milka.MakeSound();
            Console.WriteLine(milka.Sex);
        }
    }
}
