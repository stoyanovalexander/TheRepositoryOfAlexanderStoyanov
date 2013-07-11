using System;

/* 4. Create a class Person with two fields – name and age. 
 * Age can be left unspecified (may contain null value. 
 * Override ToString() to display the information of a 
 * person and if age is not specified – to say so. 
 * Write a program to test this functionality. */


class MainPerson
{
    static void Main()
    {
        Person testPerson01 = new Person("Ivan Ivanov", 20);
        Person testPerson02 = new Person("Georgi Georgiev");
        Console.WriteLine(testPerson01);
        Console.WriteLine(testPerson02);
        Console.WriteLine();
    }
}

