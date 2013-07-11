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
            new Student() {Name = "Petar", Family = "Zlatev", Age = 28},
            new Student() {Name = "Asen", Family = "Borisov", Age = 28},
        };
        for (int i = 0; i < arrStudents.Length; i++)
        {
            Console.WriteLine(arrStudents[i]);
        }
        Console.WriteLine();
        var someStudents =
            from student in arrStudents
            where (student.Name.CompareTo(student.Family) == -1)
            select new Student() { Name = student.Name, Family = student.Family, Age = student.Age };
        foreach (var item in someStudents)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
         var extStudents=arrStudents.ToList().FindAll((x)=>(x.Name.CompareTo(x.Family)==-1));
         foreach (var item in extStudents)
        {
            Console.WriteLine(item);
        }
    }
}

