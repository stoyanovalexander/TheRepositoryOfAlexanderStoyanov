using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Frames
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        string[] dadaMin = new string[N];
        string[] dadaMax=new string[N];

        for (int i = 0; i<N; i++)
        {
            string line=Console.ReadLine();
            string[] nums = line.Split(' ');
            int min=Math.Min(int.Parse(nums[0]),int.Parse(nums[1]));
            int max = Math.Max(int.Parse(nums[0]), int.Parse(nums[1]));
            dadaMin[i] = "(" + min + ", " + max + ")";
            dadaMax[i] = "(" + max + ", " + min + ")";
        }

        //for (int i = 0; i < N; i++)
        //{
        //    Console.WriteLine(dadaMin[i]);
        //}

        for (int i = 0; i < (N * N)-1; i++)
        {
            string[] dadaForPrint = new string[N];
            int print = i;

            for (int j = N-1; j >= 0; j--)
            {
                int myThink = print % 2;
                if (myThink == 0)
                {
                    dadaForPrint[j] = dadaMin[j];
                }
                else
                {
                    dadaForPrint[j] = dadaMax[j];
                }

                print = print / 2;
            }

            for (int k = 0; k < N-1; k++)
            {
                Console.Write(dadaForPrint[k] + " | ");
            }
            Console.Write(dadaForPrint[N - 1]);
            Console.WriteLine();

        }

        
    }
}
