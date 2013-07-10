using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            // Solve
            int R = 1;
            while (true)
            {
                if (((R % a == 0) && (R % b == 0) && (R % c == 0)) ||
                   ((R % a == 0) && (R % b == 0) && (R % d == 0)) ||
                   ((R % a == 0) && (R % b == 0) && (R % e == 0)) ||
                   ((R % a == 0) && (R % c == 0) && (R % d == 0)) ||
                   ((R % a == 0) && (R % c == 0) && (R % e == 0)) ||
                   ((R % a == 0) && (R % d == 0) && (R % e == 0)) ||
                   ((R % b == 0) && (R % c == 0) && (R % d == 0)) ||
                   ((R % b == 0) && (R % c == 0) && (R % e == 0)) ||
                   ((R % b == 0) && (R % d == 0) && (R % e == 0)) ||
                   ((R % c == 0) && (R % d == 0) && (R % e == 0)))
                {
                    Console.WriteLine(R);
                    break;
                }
                R++;
            }
        }
    }

