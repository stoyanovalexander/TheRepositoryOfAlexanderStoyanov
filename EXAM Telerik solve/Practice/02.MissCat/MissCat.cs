using System;
    class MissCat
    {
        static void Main()
        {
            // Input data
            int numberOfJudjes = int.Parse(Console.ReadLine());
            int[] cat = new int[11];
            for (int i = 1; i <= numberOfJudjes; i++)
            {
                int desisionOfJudge = int.Parse(Console.ReadLine());
                if (desisionOfJudge == 1)
                {
                    cat[1]++;
                }
                else if (desisionOfJudge == 2)
                {
                    cat[2]++;
                }
                else if (desisionOfJudge == 3)
                {
                    cat[3]++;
                }
                else if (desisionOfJudge == 4)
                {
                    cat[4]++;
                }
                else if (desisionOfJudge == 5)
                {
                    cat[5]++;
                }
                else if (desisionOfJudge == 6)
                {
                    cat[6]++;
                }
                else if (desisionOfJudge == 7)
                {
                    cat[7]++;
                }
                else if (desisionOfJudge == 8)
                {
                    cat[8]++;
                }
                else if (desisionOfJudge == 9)
                {
                    cat[9]++;
                }
                else //if (desisionOfJudge == 9)
                {
                    cat[10]++;
                }
            }
            // Solve
            if ((cat[1] >= cat[2]) && (cat[1] >= cat[3]) && (cat[1] >= cat[4]) && (cat[1] >= cat[5]) && (cat[1] >= cat[6])
                && (cat[1] >= cat[7]) && (cat[1] >= cat[8]) && (cat[1] >= cat[9]) && (cat[1] >= cat[10]))
            {
                Console.WriteLine(1);
            }
            else if ((cat[2] >cat[1]) && (cat[2] >= cat[3]) && (cat[2] >= cat[4]) && (cat[2] >= cat[5]) && (cat[2] >= cat[6])
                && (cat[2] >= cat[7]) && (cat[2] >= cat[8]) && (cat[2] >= cat[9]) && (cat[2] >= cat[10]))
            {
                Console.WriteLine(2);
            }
            else if ((cat[3] >cat[1]) && (cat[3] > cat[2]) && (cat[3] >= cat[4]) && (cat[3] >= cat[5]) && (cat[3] >= cat[6])
                && (cat[3] >= cat[7]) && (cat[3] >= cat[8]) && (cat[3] >= cat[9]) && (cat[3] >= cat[10]))
            {
                Console.WriteLine(3);
            }
            else if ((cat[4] > cat[1]) && (cat[4] > cat[2]) && (cat[4] > cat[3]) && (cat[4] >= cat[5]) && (cat[4] >= cat[6])
                && (cat[4] >= cat[7]) && (cat[4] >= cat[8]) && (cat[4] >= cat[9]) && (cat[4] >= cat[10]))
            {
                Console.WriteLine(4);
            }
            else if ((cat[5] > cat[1]) && (cat[5] > cat[2]) && (cat[5] > cat[3]) && (cat[5] > cat[4]) && (cat[5] >= cat[6])
                && (cat[5] >= cat[7]) && (cat[5] >= cat[8]) && (cat[5] >= cat[9]) && (cat[5] >= cat[10]))
            {
                Console.WriteLine(5);
            }
            else if ((cat[6] > cat[1]) && (cat[6] > cat[2]) && (cat[6] > cat[3]) && (cat[6] > cat[4]) && (cat[6] > cat[5])
                && (cat[6] >= cat[7]) && (cat[6] >= cat[8]) && (cat[6] >= cat[9]) && (cat[6] >= cat[10]))
            {
                Console.WriteLine(6);
            }
            else if ((cat[7] > cat[1]) && (cat[7] > cat[2]) && (cat[7] > cat[3]) && (cat[7] > cat[4]) && (cat[7] > cat[5])
                && (cat[7] > cat[6]) && (cat[7] >= cat[8]) && (cat[7] >= cat[9]) && (cat[7] >= cat[10]))
            {
                Console.WriteLine(7);
            }
            else if ((cat[8] > cat[1]) && (cat[8] > cat[2]) && (cat[8] > cat[3]) && (cat[8] > cat[4]) && (cat[8] > cat[5])
                && (cat[8] > cat[6]) && (cat[8] > cat[7]) && (cat[8] >= cat[9]) && (cat[8] >= cat[10]))
            {
                Console.WriteLine(8);
            }
            else if ((cat[9] > cat[1]) && (cat[9] > cat[2]) && (cat[9] > cat[3]) && (cat[9] > cat[4]) && (cat[9] > cat[5])
                && (cat[9] > cat[6]) && (cat[9] > cat[7]) && (cat[9] > cat[8]) && (cat[9] >= cat[10]))
            {
                Console.WriteLine(9);
            }
            else
            {
                Console.WriteLine(10);
            }
        }
    }

