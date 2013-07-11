using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class BankSystemTest
    {
        static void Main(string[] args)
        {
            Acount[] someBankAcounts = { new Deposit(new IndividualCustomer("Ivan Ivanov", "62-11-33", "8603441156"),2545.50, 0.03),
                                   new Loan(new CompanyCustomer("Dako-Plast OOD", "62-12-44", "Lidia Koeva"), 2000, 0.06),
                                   new Mortgage(new IndividualCustomer("Huren chkr", "62-06-55", "9874563258"), 123.00, 0.04)};

            Console.WriteLine("=========The Acounts=========");
            Console.WriteLine();
            foreach (var acount in someBankAcounts)
            {
                acount.PrintInfo();
            }
            Console.WriteLine();
            foreach (var acount in someBankAcounts)
            {
                Console.Write("Enter number of months for interest: ");
                int months = int.Parse(Console.ReadLine());
                Console.WriteLine("The {0} has interest: {1}", acount.GetType().Name, acount.CalculateInterestAmount(months));
            }

            Console.WriteLine();
            foreach (var acount in someBankAcounts)
            {
                Console.Write("Deposit some sum: ");
                double sum = double.Parse(Console.ReadLine());
                acount.Deposit(sum);
                acount.PrintInfo();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Deposit myDeposit = new Deposit(new IndividualCustomer("Asen Agov", "62-33-44", "4455443456"), 2000, 0.01);
            myDeposit.PrintInfo();
            Console.WriteLine("Enter the sum to with draw: ");
            double sumToWithDraw = double.Parse(Console.ReadLine());

            myDeposit.WithDraw(sumToWithDraw);
            myDeposit.PrintInfo();

        }
    }
}
