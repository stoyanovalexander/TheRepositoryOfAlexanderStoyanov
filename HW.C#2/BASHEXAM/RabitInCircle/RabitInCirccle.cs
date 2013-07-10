using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RabitInCirccle
    {
        static void Main(string[] args)
        {

            string terrain = Console.ReadLine();
            string[] nums = terrain.Split(',');
            int[] bashNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                bashNums[i] = int.Parse(nums[i]);
            }
                //for (int i = 0; i < nums.Length; i++)
                //{
                //  Console.WriteLine(nums[i]);
                //}
            int bestcount = 0;
            int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 1; j < nums.Length; j++)
                    {
                        int index = i;
                        while (bashNums[index] < bashNums[(index + j) % bashNums.Length])
                        {
                            index = (index + j)%bashNums.Length;
                            count++;
                        }
                        if (count > bestcount)
                        {
                            bestcount = count;
                        }
                        count = 0;
                    }

                }
                bestcount = bestcount + 1;
                Console.WriteLine(bestcount);
        }
    }

