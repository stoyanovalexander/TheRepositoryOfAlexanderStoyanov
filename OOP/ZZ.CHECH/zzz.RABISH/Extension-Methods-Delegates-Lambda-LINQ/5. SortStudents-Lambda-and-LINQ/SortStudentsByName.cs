/* Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and 
 * last name in descending order. Rewrite the same with LINQ.
 */

using System;
using System.Linq;

class FindStudentsByAge
{
    static void Main()
    {
        var students = new[]
        {
            new{ firstName = "Angel" , lastName = "Todorov"},
            new{ firstName = "Elenko", lastName = "Davidkov"},
            new{ firstName = "Ivan", lastName = "Petrov"},
            new{ firstName = "Pesho", lastName = "Ivanov"},
            new{ firstName = "Pesho", lastName = "Angelov"},
        };

        //Order students using LINQ
        var sortedStudents1 =
            from student in students
            orderby student.firstName, student.lastName
            select student;

        Console.WriteLine("Students sort By Name with LINQ");
        Console.WriteLine("===============================");
        foreach (var item in sortedStudents1)
        {
            string[] student = item.ToString().Trim('}').Split(',');
            student[0] = student[0].Remove(0, 14);
            student[1] = student[1].Remove(0, 12);
            Console.WriteLine("{0} {1}", student[0], student[1]);
        }
        Console.WriteLine();

        //Order students using Lambda Expression
        var sortedStudents2 = students.OrderBy(x => x.firstName).ThenBy(y => y.lastName);
    
        Console.WriteLine("Students sort By Name with Lambda Expression");
        Console.WriteLine("============================================");
        foreach (var item in sortedStudents2)
        {
            string[] student = item.ToString().Trim('}').Split(',');
            student[0] = student[0].Remove(0, 14);
            student[1] = student[1].Remove(0, 12);
            Console.WriteLine("{0} {1}", student[0], student[1]);
        }
        Console.WriteLine();
    }
}

