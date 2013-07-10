using System;
class AddingPolynomials
{
    private static int GettingSize(string p)
    {
        if (p == "first")
        {
            return 3;
        }
        if (p == "second")
        {
            return 3;
        }
        return 0;
    }
    static int[] GivingValues(int num, string p)
    {
        int[] arr = new int[num];
        if (p == "first")
        {
            arr[0] = 4;
            arr[1] = 8;
            arr[2] = 9;
        }
        if (p == "second")
        {
            arr[0] = 0;
            arr[1] = -8;
            arr[2] = 5;
        }
        return arr;
    }

    static int[] SumingPolynomials(int[] polyOne, int[] polyTwo)
    {
        int[] polyResult = new int[Math.Max(polyOne.Length, polyTwo.Length)];
        for (int i = polyResult.Length - 1; i >= 0; i--)
        {
            if (i < polyOne.Length && i < polyTwo.Length)
            {
                polyResult[i] = polyOne[i] + polyTwo[i];
            }
            else if (i < polyOne.Length)
            {
                polyResult[i] = polyOne[i];
            }
            else
            {
                polyResult[i] = polyTwo[i];
            }
        }
        return polyResult;
    }
    static void SignPrinting(int number)
    {
        if (number < 0)
        {
            Console.Write(" - ");
        }
        else
        {
            Console.Write(" + ");
        }
    }

    static void ResultPrinting(int[] polyResult)
    {
        for (int i = 0; i < polyResult.Length; i++)
        {
            if (polyResult[i] != 0)
            {
                if (i > 0 || polyResult[i] < 0)
                {
                    SignPrinting(polyResult[i]);
                }
                Console.Write(Math.Abs(polyResult[i]));
                if (i < polyResult.Length - 1)
                {
                    Console.Write("x");
                    if (i < polyResult.Length - 2)
                    {
                        Console.Write(polyResult.Length - i - 1);
                    }
                }
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Polynomial One = 4(x2) +8(x) + 9");
        Console.WriteLine("Polynomial Two =  -8(x) + 5");
        int n = GettingSize("first");
        int[] polyOne = new int[n];
        polyOne = GivingValues(n, "first");
        int m = GettingSize("second");
        int[] polyTwo = new int[m];
        polyTwo = GivingValues(m, "second");
        Console.Write("Polynomials One + Two = ");
        int[] polyResult = SumingPolynomials(polyOne, polyTwo);
        ResultPrinting(polyResult);
        Console.Write("Polynomials One - Two = ");
        polyResult = SubtractingPolynomials(polyOne, polyTwo);
        ResultPrinting(polyResult);
        Console.Write("Polynomials One * Two = ");
        polyResult = MultiplingPolynomials(polyOne, polyTwo);
        ResultPrinting(polyResult);
    }
    static int[] SubtractingPolynomials(int[] polyOne, int[] polyTwo)
    {
        int[] polyResult = new int[Math.Max(polyOne.Length, polyTwo.Length)];
        for (int i = polyResult.Length - 1; i >= 0; i--)
        {
            if (i < polyOne.Length && i < polyTwo.Length)
            {
                polyResult[i] = polyOne[i] - polyTwo[i];
            }
            else if (i < polyOne.Length)
            {
                polyResult[i] = polyTwo[i];
            }
            else
            {
                polyResult[i] = polyTwo[i];
            }
        }
        return polyResult;
    }
    static int[] MultiplingPolynomials(int[] polyOne, int[] polyTwo)
    {
        int[] polyResult = new int[polyOne.Length + polyTwo.Length - 1];
        for (int i = 0; i < polyOne.Length; i++)
        {
            for (int j = 0; j < polyTwo.Length; j++)
            {
                polyResult[i + j] += polyOne[i] * polyTwo[j];
            }
        }
        return polyResult;
    }
}
