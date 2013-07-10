using System;
class Program
{
    static void Main(string[] args)
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            long num = long.Parse(Console.ReadLine());
            while (num != 0)
            {
                if ((num & 1) == b)
                {
                    count++;
                }
                num = num >> 1;
            }
            Console.WriteLine(count);
        }
    }
}

