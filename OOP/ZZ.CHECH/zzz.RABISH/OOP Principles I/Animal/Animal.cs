using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Animal
    {
        public  string Name { get; set; }
        public  string Sex { get; set; }
        public  double Age { get; set; }

        public Animal(string name, double age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public void IdentifyAnimal()
        {
            Console.WriteLine(GetType().Name);
        }

        public static double AverageAge(Animal[] array)
        {
            int animalsCount = array.Length;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i].Age;
            }
            return sum / animalsCount;
        }
    }
}
