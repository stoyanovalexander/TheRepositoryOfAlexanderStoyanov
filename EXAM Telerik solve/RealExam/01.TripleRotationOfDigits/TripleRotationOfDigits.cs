﻿using System;
    static class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());

            int digitNum = 33;
            for (int i = 1; i <= 100; i++)
            {
                if ((k / (int)Math.Pow(10.0, (i)) == 0) )
                {
                    digitNum = i-1;
                    break;
                }
                //else if ((k / (int)Math.Pow(10.0, (i)) == 1) && (k % (int)Math.Pow(10.0, (i)) == 0))
                //{
                  //  digitNum = i;
                   // break;
                //}
            }



            
                for (int i = 1; i <= 3; i++)
                {
                    int lastDigit = k % 10;
                    k = k / 10;
                    k = k + lastDigit * (int)Math.Pow(10.0, (digitNum));
                }
                Console.WriteLine(k);
        
        }
    }

