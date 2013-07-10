using System;
using System.Collections.Generic;


    class TwoTasks
    {
        //int forChange=0;
          //  int reverse = 0;
            //while (num != 0)
            //{
              //   forChange= num % 10;
                // reverse = reverse * 10 + forChange;
                 //num = num / 10;
            //}
            //Console.WriteLine("   reversed is:  "+reverse)


        static void Main(string[] args)
        {
            string AB = Console.ReadLine();
            string theList = Console.ReadLine();
            string procent = Console.ReadLine();


            string[] AandB = AB.Split(' ');
            ulong A = ulong.Parse(AandB[0]);
            ulong B = ulong.Parse(AandB[1]);
            //ulong[] allBetweenAB = new ulong[B - A + 1];
            //ulong result = B - A;
            //List<ulong> allBetweenAB = new List<ulong>();
            //for (ulong i = A; i <= B; i++)
            //{
              //  allBetweenAB.Add(i);
            //}

            //for(ulong P=A;P<=B;P++)
            //{
            ulong count = 0;
            for (ulong i = A; i <= B; i++)
            {
                ulong forChange = 0;
                ulong reverse = 0;
                ulong goDown = i;
                while (goDown != 0)
                {
                    forChange = goDown % 10;
                    reverse = reverse * 10 + forChange;
                    goDown = goDown / 10;
                }
                if (reverse == i)
                {
                    bool lucky = true;
                    ulong reminder = 0;
                    while (reverse != 0)
                    {
                        reminder = reverse % 10;
                        reverse = reverse / 10;
                        if ((reminder != 3) && (reminder != 5))
                        {
                            lucky = false;
                        }
                    }
                    if (lucky == true)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);



            string[] theListParts = theList.Split(',');
            int[] theListNums=new int[theListParts.Length];
            for (int i = 0; i < theListParts.Length; i++)
            {
                theListNums[i] = int.Parse(theListParts[i]);
            }
            int theProcent = int.Parse(procent);
            int numberSmaller = (theListNums.Length * theProcent) / 100;
            Array.Sort(theListNums);
            Console.WriteLine(theListNums[numberSmaller]);
             
        }
        }
    

