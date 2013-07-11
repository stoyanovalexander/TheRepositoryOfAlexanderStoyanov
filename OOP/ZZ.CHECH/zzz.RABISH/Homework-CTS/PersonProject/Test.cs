using System;

namespace PersonProject
{
    class Test
    {
        static void Main()
        {
            Person person = new Person("Pesho");
            Console.WriteLine(person.ToString()); //Nullable age

            person.Age = 22;
            Console.WriteLine(person.ToString()); //With setted age
        }
    }
}