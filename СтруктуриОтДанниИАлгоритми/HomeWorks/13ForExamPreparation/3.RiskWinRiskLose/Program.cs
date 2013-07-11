using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string startComb = Console.ReadLine();
            string endComb = Console.ReadLine();

            HashSet<string> visited = new HashSet<string>();
            int forbidenCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < forbidenCount; i++)
            {
                visited.Add(Console.ReadLine());
            }

            Queue<Tuple<string, int>> queue = new Queue<Tuple<string, int>>();
            queue.Enqueue(new Tuple<string, int>(startComb, 0));
            visited.Add(startComb);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Item1 == endComb)
                {
                    Console.WriteLine(current.Item2);
                    return;
                }

                StringBuilder sb = new StringBuilder(current.Item1);
                for (int i = 0; i < 5; i++)
                {
                    int digit = current.Item1[i] - '0';
                    digit++;
                    if (digit==10)
                    {
                        digit = 0;
                    }

                    sb[i] = (char)(digit + '0');
                    string newNode = sb.ToString();

                    if (!visited.Contains(newNode))
                    {
                        visited.Add(newNode);
                        queue.Enqueue(new Tuple<string, int>(newNode, current.Item2 + 1));
                    }

                    sb[i] = current.Item1[i];
                }

                for (int i = 0; i < 5; i++)
                {
                    int digit = current.Item1[i] - '0';
                    digit--;
                    if (digit == -1)
                    {
                        digit = 9;
                    }

                    sb[i] = (char)(digit + '0');
                    string newNode = sb.ToString();
                    if (!visited.Contains(newNode))
                    {
                        visited.Add(newNode);
                        queue.Enqueue(new Tuple<string,int>(newNode,current.Item2+1));
                    }
                    sb[i] = current.Item1[i];
                }
            }

            Console.WriteLine(-1);
        }
    }

