using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AcademytasksOnlyGoodway
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] tasksAsString = line.Split(new char[] {',',' '},
                StringSplitOptions.RemoveEmptyEntries);
            int[] tasks = new int[tasksAsString.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = int.Parse(tasksAsString[i]);
            }

            int variety = int.Parse(Console.ReadLine());
            Console.WriteLine(Solve(tasks,variety));
        }

        public static int Solve(int[] tasks, int variety)
        {
            int minCount = tasks.Length;
            for (int i = 0; i < tasks.Length - 1; i++)
            {
                for (int j = i + 1; j < tasks.Length; j++)
                {
                    if (Math.Abs(tasks[i] - tasks[j]) >= variety)
                    {
                        int count = 0;
                        count += (i+1) / 2;
                        count += (j - i+1) / 2+1;
                        minCount = Math.Min(minCount, count);
                    }
                }
            }

            return minCount;
        }
    }

