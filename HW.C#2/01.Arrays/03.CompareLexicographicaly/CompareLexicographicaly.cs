using System;
    class CompareLexicographicaly
    {
        static void Main()
        {
            Console.Write("enter first= ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second= ");
            int second = int.Parse(Console.ReadLine());
            int stop = Math.Min(first, second);
            char[] firstArray=new char[first];
            char[] secondArray=new char[second];
            bool bigger = false;
            Console.WriteLine("firstArray");
            for(int i=0;i<first;i++)
            {
                firstArray[i]=char.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();;
            Console.WriteLine("secondArray");
            for(int j=0;j<second;j++)
            {
                secondArray[j]=char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < stop; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("1:firstArray;  2:secondArray");
                    bigger = true;
                    break;
                }
                else if (secondArray[i] < firstArray[i])
                {
                    Console.WriteLine("1:secondArray;  2:firstArray");
                    bigger = true;
                    break;
                }
            }
            if (bigger == false)
            {
                if (first < second)
                {
                    Console.WriteLine("1:firstArray;  2:secondArray");
                }
                else if (second < first)
                {
                    Console.WriteLine("1:secondArray;  2:firstArray");
                }
                else
                {
                    Console.WriteLine("firstArray=secondArray  lexicographicaly");
                }
            }
        }
    }

