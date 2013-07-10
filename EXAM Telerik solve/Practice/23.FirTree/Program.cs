using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            int N=int.Parse(Console.ReadLine());

            // Solve
            int midle=(1+2*(N-2)+1)/2;
            for(int i=1;i<=N-1;i++)
            {
                for(int j=1;j<=1+2*(N-2);j++)
                {
                    if((j>=(midle-i+1))&&(j<=(midle+i-1)))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            for(int i=1;i<=(1+2*(N-2));i++)
            {
                if(i==midle) Console.Write('*');
                else
                {
                    Console.Write('.');
                }
            }
        }
    }

