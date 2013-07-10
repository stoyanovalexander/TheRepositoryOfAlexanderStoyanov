using System;
using System.Numerics;
class OddNumber
{
    static void Main()
    {
       // Input data
        int N = int.Parse(Console.ReadLine());
        BigInteger result = 0;
        for (int i = 1; i <= N; i++)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            result = result ^ num;
        }
        Console.WriteLine(result);
    }
}
