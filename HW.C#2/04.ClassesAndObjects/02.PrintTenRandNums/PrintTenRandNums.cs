using System;
    class PrintTenRandNums
    {
        private static Random rnd = new Random();
        static void Main()
        {
            int randNum = 0;
            Console.WriteLine("Ten random numbers [100,200]");
            for (int i = 0; i < 10; i++)
            {
                randNum = rnd.Next(100, 201);
                Console.WriteLine(randNum);
            }
        }
    }
