using System;
    class First10Members
    {
        static void Main()
        {
            for (double i = 2; i <= 11; i++)
            {            
                double member = i* Math.Pow(-1.0, i);
                Console.Write(" " + member);
            }
            Console.WriteLine("   ");
        }
    }

