using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.InvalidRangeException
{
    class Program
    {
        static void Main()
        {
            InvalidRangeException<int> intExeption =
                new InvalidRangeException<int>("The range is not valid must be between[1, 100]!", 1, 100);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter range in the interval [0,100]:");
                int range = int.Parse(Console.ReadLine());
                if (range<intExeption.Start|| range>intExeption.End)
                {
                    throw intExeption;
                }
            }
            string aaa = "asdf";
              int sss=aaa.Length;
              Console.WriteLine(sss);
        //    string startDate="1/1/1980";
        //    string endDate="1/1/2013";

        //    InvalidRangeException<DateTime> dateExpection =
        //        new InvalidRangeException<DateTime>("The date is not valid it must be in the interval [1/1/1980, 1/1/2013]!"
        //            ,DateTime.Parse(startDate),DateTime.Parse(endDate));
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine("Enter a date in the format: yyyy,mm.dd! Which is:[1/1/1980, 1/1/2013]");
        //        string date = Console.ReadLine();
        //        DateTime theDate = DateTime.Parse(date);
        //        if (theDate.Year<dateExpection.Start.Year || theDate.Year>dateExpection.End.Year)
        //        {
        //            throw dateExpection;
        //        }
        //    } 
        }
    }
}