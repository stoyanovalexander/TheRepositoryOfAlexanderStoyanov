using System;
    class MaxElmInPartOfArr
    {
        static int MaxElement(int[] arr, int start, int end)
        {
            for (int i = start; i <= end-1; i++)
            {
                for (int j = i + 1; j <= end; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int change = arr[i];
                        arr[i] = arr[j];
                        arr[j] = change;
                    }
                }
            }
            return arr[start];
        }
        static void Main()
        {
            Console.Write("Enter someArrLen=");
            int someArrLen = int.Parse(Console.ReadLine());
            Console.Write("Enter someStartIndex=");
            int someStartIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter someEndIndex=");
            int someEndIndex = int.Parse(Console.ReadLine());
            int[] someArr=new int[someArrLen];
            Console.WriteLine("Enter someArr");
            // Fill tht array
            for (int i = 0; i < someArrLen;i++ )
            {
                someArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("[{0},{1}]→ maxNumber={2}",someStartIndex,someEndIndex,
                MaxElement(someArr,someStartIndex,someEndIndex));
        }
    }

