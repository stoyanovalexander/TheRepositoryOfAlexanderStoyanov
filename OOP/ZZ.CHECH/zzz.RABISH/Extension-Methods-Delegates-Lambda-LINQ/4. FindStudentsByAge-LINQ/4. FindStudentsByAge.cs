/* Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. */

using System;
using System.Linq;

class FindStudentsByAge
{
    static void Main()
    {
        var students = new[]
        {
            new{ firstName = "Angel" , lastName = "Todorov", age = 26},
            new{ firstName = "Elenko", lastName = "Davidkov", age = 17},
            new{ firstName = "Ivan", lastName = "Petrov", age = 19},
            new{ firstName = "Pesho", lastName = "Ivanov", age = 23},
            new{ firstName = "Todor", lastName = "Angelov", age = 20},
        };

        var findedStudents =
            from student in students
            where student.age > 18 && student.age < 24
            select student;

        Console.WriteLine("Students between 18 and 24 Years old:");
        Console.WriteLine("====================================");
        foreach (var item in findedStudents)
        {
            string[] student = item.ToString().Trim('}').Split(',');
            student[0] = student[0].Remove(0, 14);
            student[1] = student[1].Remove(0, 12);
            student[2] = student[2].Remove(0, 6);
            Console.WriteLine("{0} {1}", student[0], student[1]);
            Console.WriteLine("Age: {0}", student[2]);
        }
        Console.WriteLine();
    }
}

