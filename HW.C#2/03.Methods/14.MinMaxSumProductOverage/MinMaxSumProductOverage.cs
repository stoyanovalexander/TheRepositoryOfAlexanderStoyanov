using System;
    class MinMaxSumProductOverage
    {
        static void Main()
        {
            Console.Write("arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            int[] arr=new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                Console.Write("arr[{0}]=",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            FindingMax(arr);
            FindingMin(arr);
            FindingSum(arr);
            FindingOverage(arr);
            FindingProduct(arr);
        }
        static void FindingMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("                Min elm is: "+min);
        }

        static void FindingMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("                Max elm is: " + max);
        }

        static void FindingSum(int[] array)
        {
            int sum =0;
            for (int i = 0; i < array.Length; i++)
            {
 
                sum = sum+array[i];
                
            }
            Console.WriteLine("         Sum of all elm is: " + sum);
        }

        static void FindingOverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                sum = sum + array[i];

            }
            double overage = (double)sum / array.Length;
            Console.WriteLine("  Oveage sum of all elm is: " + overage);
        }

        static void FindingProduct(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {

                product = product * array[i];

            }
            Console.WriteLine("     Product of all elm is: " + product);
        }
    }

