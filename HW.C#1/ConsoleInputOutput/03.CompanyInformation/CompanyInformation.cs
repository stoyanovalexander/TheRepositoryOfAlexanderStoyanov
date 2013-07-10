using System;
    class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string address = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string fax = Console.ReadLine();
            Console.Write("Enter company phone: ");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter company manager last name: ");
            string lastName = Console.ReadLine();
            string fullName = firstName + lastName;
            Console.Write("Enter manager phone: ");
            string mangPhone = Console.ReadLine();
            Console.Write("Enter manager age: ");
            int age = int.Parse(Console.ReadLine());
            //To here give iformation for company and manager.
            //From here print that information.
            Console.WriteLine("Company name: {0}, address: {1}, fax {2}, phone: {3}, manager: {4}",compName,address,fax,compPhone,fullName);
            Console.WriteLine("Manager first name: {0}, last name: {1}, phone: {2}, age: {3}",firstName,lastName,mangPhone,age);
        }
    }
