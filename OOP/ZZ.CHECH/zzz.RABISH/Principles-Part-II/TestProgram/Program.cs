using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Task1;
using Task2;
using Task3;

namespace TestProgram
{
    class Program
    {
        static void Main()
        {
        //task.1
            Shape[] shapes ={
                                new Rectangle(5,4),
                                new Rectangle(0,10),
                                new Circle(5),
                                new Triangle(7,8),
                                new Triangle(1,1),
                                new Rectangle(100,100),
                                new Rectangle(25,0),
                                new Circle(1),
                                new Circle(15),
                            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(String.Format("{0:0.00}",shape.CalculateSurface()));
            }
            Console.WriteLine();
            Console.WriteLine();

        //Task.2   
            List<Customer> customers = new List<Customer>();
            customers.Add(new Individual(26, "Stilian Georgiev", Sex.Male));
            customers.Add(new Individual(45, "Kiro Skuluta", Sex.Male));
            customers.Add(new Individual(24, "Kaka Mara", Sex.Female));
            customers.Add(new Company("Makaroni OOD", "156423123" ));
            customers.Add(new Company("Peralnq i KO EOOD", "456321555"));
            customers.Add(new Company("MoaAkopa", "123654789"));

            List<Account> accounts = new List<Account>();
            accounts.Add(new Deposit(customers[0], 1010, 0.06m, 10));
            accounts.Add(new Deposit(customers[1], 2000, 0.1m, 10));
            accounts.Add(new Deposit(customers[2], 1000, 0.06m, 10));
            accounts.Add(new Loan(customers[3], 1000, 0.06m, 10)); 
            accounts.Add(new Mortgage(customers[4], 1000, 0.06m, 10));

            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalculateInterest());
                account.DepositMoney(5000);
                if (account is Deposit)
                {
                    account.WithDraw(100);
                    Console.WriteLine("Draw Successful ");
                }
            }


        //Task.3
            int start = 1;
            int end = 100;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            try
            {
                int number = ReadInteger(start, end);
                Console.WriteLine("Your number: " + number);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0}\nRange: [{1}...{2}]", ex.Message, ex.Start, ex.End);
            }

            try
            {
                DateTime date = ReadDate(startDate, endDate);
                Console.WriteLine("Your date: " + date.ToString(DATE_FORMAT));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0}\nRange: [{1} - {2}]", ex.Message, ex.Start.ToString(DATE_FORMAT), ex.End.ToString(DATE_FORMAT));
            }
        }


        //methods
        private const string DATE_FORMAT = "d.M.yyyy";

        private static int ReadInteger(int start, int end)
        {
            int number;
            string inputValue;

            do
            {
                Console.Write("Enter an integer in the range [{0}...{1}]: ", start, end);
                inputValue = Console.ReadLine();
            }
            while (!Int32.TryParse(inputValue, out number));

            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>("Input value was not in the permissible range.", start, end);
            }

            return number;
        }

        private static DateTime ReadDate(DateTime start, DateTime end)
        {
            DateTime date;
            string inputValue;

            do
            {
                Console.Write("Enter a date in the range [{0} - {1}]: ", start.ToString(DATE_FORMAT), end.ToString(DATE_FORMAT));
                inputValue = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(inputValue, DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out date));

            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>("Input value was not in the permissible range.", start, end);
            }

            return date;
        }
    }
}
