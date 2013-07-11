using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalDogFrogCat
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }

        public Animal(int age, string name, char sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void IdentifyAnimal()
        {
            Console.WriteLine("I am " + GetType().Name);
        }

        public static double Average(Animal[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i].Age;
            }
            return sum / array.Length;
        }
    }
}
