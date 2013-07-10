using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 2; i++)
            { 
                string dot=new string('.',n-2-i);
                string star = new string('*',i*2+1);
                Console.WriteLine("{0}{1}{2}",dot,star,dot);
            }
            string lastDot = new string('.',n-2);
            string lastStar = new string('*',1);
            Console.WriteLine("{0}{1}{2}",lastDot,lastStar,lastDot);
        }
    }
