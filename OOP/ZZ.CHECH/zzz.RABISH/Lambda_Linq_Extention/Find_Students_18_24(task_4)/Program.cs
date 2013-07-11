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
            new Student() {Name = "Georgri", Family = "Petkov", Age = 27},
            new Student() {Name = "Petar", Family = "Zlatev", Age = 18},
            new Student() {Name = "Asen", Family = "Borisov", Age = 28},
        };
        for (int i = 0; i < arrStudents.Length; i++)
        {
            Console.WriteLine(arrStudents[i]);
        }
        Console.WriteLine();
        var someStudents =
            from student in arrStudents
            where ((student.Age>=18) && (student.Age<=24))
            select new { Name = student.Name, Family = student.Family};

        foreach (var item in someStudents)
        {
            Console.WriteLine(item);
        }
    }
}

