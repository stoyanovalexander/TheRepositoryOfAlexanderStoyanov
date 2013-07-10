using System;
    class Hallo
    {
        static void SayHello(string name)
        {
            Console.WriteLine("What is your name:");
            Console.WriteLine("Hello {0}",name);
        }
        static void Main()
        {
            Console.Write("Enter your name: ");
            string someName = Console.ReadLine();
            SayHello(someName);
        }
    }

