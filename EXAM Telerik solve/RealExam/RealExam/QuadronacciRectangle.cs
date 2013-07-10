using System;
    static class Program
    {
        static void Main()
        {
            long Q1 = long.Parse(Console.ReadLine());
            long Q2 = long.Parse(Console.ReadLine());
            long Q3 = long.Parse(Console.ReadLine());
            long Q4 = long.Parse(Console.ReadLine());
            long r = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long numQ = r * c;
            long nextQ=0;
            long[] q = new long[numQ + 1];

            q[1]=Q1;
            q[2]=Q2;
            q[3]=Q3;
            q[4]=Q4;

            for(int i=5;i<=numQ;i++)
            {
                nextQ=Q1+Q2+Q3+Q4;
                Q1=Q2;
                Q2=Q3;
                Q3=Q4;
                Q4=nextQ;
                q[i]=nextQ;
            }

            for(int i=1;i<=r;i++)
            {
                for(int j=1;j<=c;j++)
                {
                    Console.Write(q[(i-1)*c+j]+" ");
                }
                Console.WriteLine();
            }

        }
    }

