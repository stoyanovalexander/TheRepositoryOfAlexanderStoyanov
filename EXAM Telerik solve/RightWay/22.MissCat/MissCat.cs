using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] cat = new int[11];
        for (int i = 0; i < N; i++)
        {
            int num = int.Parse(Console.ReadLine());
            cat[num]++;
        }
        int winner = 1;
        int biggest = cat[1];
        for (int i = 2; i <= 10; i++)
        {
            if (cat[i] > biggest)
            {
                winner = i;
                biggest = cat[i];
            }
        }
        Console.WriteLine(winner);
    }
}

