/* Write a method that from a given array of students finds all students whose first name is before its last name 
 * alphabetically. Use LINQ query operators.
 */

using System;
using System.Linq;

class FindStudentsByName
{
    static void Main()
    {
        var students = new[]
        {
            new{ firstName = "Angel" , lastName = "Todorov"},
            new{ firstName = "Elenko", lastName = "Davidkov"},
            new{ firstName = "Ivan", lastName = "Petrov"},
            new{ firstName = "Pesho", lastName = "Ivanov"},
            new{ firstName = "Todor", lastName = "Angelov"},
        };

        var findedStudents =
            from student in students
            where (student.firstName).CompareTo(student.lastName) < 0
            select student;

        Console.WriteLine("Students witch First Name is before its Last Name:");
        Console.WriteLine("==================================================");
        foreach (var item in findedStudents)
        {
            string[] student = item.ToString().Trim('}').Split(',');
            student[0] = student[0].Remove(0, 14);
            student[1] = student[1].Remove(0, 12);
            Console.WriteLine("{0} {1}", student[0], student[1]);
        }
        Console.WriteLine();            
    }
}

