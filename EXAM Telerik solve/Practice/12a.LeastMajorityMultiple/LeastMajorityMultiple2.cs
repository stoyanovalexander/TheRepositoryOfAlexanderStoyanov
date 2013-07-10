using System;
    class LeastMajorityMultiple2
    {
        static void Main()
        {
            // Input data
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            // Sove
            int R=1;
            while (true)
            {
                int count = 0;
                if (R % a == 0) count++;
                if (R % b == 0) count++;
                if (R % c == 0) count++;
                if (R % d == 0) count++;
                if (R % e == 0) count++;
                if (count >= 3)
                {
                    Console.WriteLine(R);
                    break;
                }
                R++;
            }
        }
    }

