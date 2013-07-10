using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[8];
            int onesNum = 0;
            int pillar = 10;
            for (int i = 0; i < 8; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int index = 0; index < 8; index++)
            {
                int leftCount = 0;
                int rightCount = 0;
                for (int left = index + 1; left < 8; left++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (((n[k] >> left) & 1 )== 1)
                        {
                            leftCount++;
                        }
                    }
                }
                for (int right = 0; right <= index - 1; right++)
                {
                    for (int p = 0; p < 8; p++)
                    {
                        if (((n[p] >> right) & 1) == 1)
                        {
                            rightCount++;
                        }
                    }
                }


                    if (leftCount == rightCount)
                    {
                        onesNum = leftCount;
                        pillar = index;
                    }
    
            }
            if (pillar != 10)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(onesNum);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

