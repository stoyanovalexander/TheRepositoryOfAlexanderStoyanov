using System;

/* 1. Define a class Student, which contains data about a 
 * student – first, middle and last name, SSN, 
 * permanent address, mobile phone e-mail, course, 
 * specialty, university, faculty. Use an enumeration 
 * for the specialties, universities and faculties. 
 * Override the standard methods, inherited by  
 * System.Object: Equals(), ToString(), 
 * GetHashCode() and operators == and !=. */

/* 2. Add implementations of the ICloneable interface. 
 * The Clone() method should deeply copy all object's 
 * fields into a new object of type Student. */

/* 3. Implement the  IComparable<Student> interface to 
 * compare students by names (as first criteria, in 
 * lexicographic order) and by social security number 
 * (as second criteria, in increasing order). */

class MainStudents
{
    static void Main()
    {
        Student testStudent = new Student("Ivan", "Ivanov", "Ivanov", 123456789, "Sofia, Mladost1, Al. Malinov str.", "0889888888",
        "ivan@mail.com", University.SofiaUniversity, Faculty.InformationTechnology, Specialty.ComputerScience, 2);
        Console.WriteLine(testStudent);
        Console.WriteLine();

        //Make second student who is deep clone of the first one and test this
        Student secondStudent = testStudent.Clone();
        Console.WriteLine(secondStudent);
        Console.WriteLine();
        secondStudent.FirstName = "Georgi";
        Console.WriteLine(secondStudent.FirstName);
        Console.WriteLine(testStudent.FirstName);
        Console.WriteLine();

        //Testing override method CompareTo
        Console.WriteLine(testStudent.CompareTo(secondStudent));
        secondStudent.FirstName = "Ivan";
        Console.WriteLine(testStudent.CompareTo(secondStudent));
        Console.WriteLine();
    }
}

