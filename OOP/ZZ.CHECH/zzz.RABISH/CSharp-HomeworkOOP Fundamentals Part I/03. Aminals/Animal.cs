using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Aminals
{
    public abstract class Animal
    {
        //Fields.
        public string Name { get; set; }
        public byte Age { get; set; }
        public Sex AnimalSex { get; protected set; }

        //Constructors.
        public Animal(string name, byte age, Sex animalSex)
        {
            this.Name = name;
            this.Age = age;
            this.AnimalSex = animalSex;
        }
        public void IntroduceAnimal()
        {
            Console.WriteLine("Name: {0}, Age: {1}, Sex: {2}", this.Name, this.Age, this.AnimalSex);
        }

        public static double GetAverageAnimalAge(List<Animal> animalList)
        {
            double totalAge = 0;
            int animalCount = 0;
            for (int i = 0; i < animalList.Count; i++)
            {
                totalAge += animalList[i].Age;
                animalCount++;
            }
            double averageAge = totalAge / animalCount;

            return averageAge;
        }
    }
}
