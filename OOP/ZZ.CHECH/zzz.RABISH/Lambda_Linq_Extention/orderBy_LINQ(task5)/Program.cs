using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;






class Program
{
    static void Main(string[] args)
    {
        Student[] arrStudents = new Student[] 
        {   
            new Student() {Name = "Pesho", Family = "Ivanov", Age = 23},
            new Student() {Name = "Asen", Family = "Petkov", Age = 27},
            new Student() {Name = "Petar", Family = "Zlatev", Age = 28},
            new Student() {Name = "Asen", Family = "Borisov", Age = 28},
            new Student() {Name = "Desko", Family = "Borisov", Age = 28},
            new Student() {Name = "Desko", Family = "Arisov", Age = 28}
        };
        for (int i = 0; i < arrStudents.Length; i++)
        {
            Console.WriteLine(arrStudents[i]);
        }
        Console.WriteLine();
        var someStudents =
            from student in arrStudents
            orderby student.Name descending, student.Family descending
            select new Student { Name = student.Name, Family = student.Family, Age = student.Age };

        foreach (var item in someStudents)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        var someStudentsLambda =
            arrStudents.OrderByDescending(x => x.Name).ThenByDescending(x => x.Family);
        foreach (var item in someStudentsLambda)
        {
            Console.WriteLine(item);
        }

    }
}

