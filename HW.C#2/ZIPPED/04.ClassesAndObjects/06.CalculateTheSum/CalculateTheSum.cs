using System;
    class CalculateTheSum
    {
        static void Main()
        {
            Console.WriteLine("Enter string with numbers with intervals between them: ");
            string strNumbers = Console.ReadLine();
            string[] nums = strNumbers.Split(' ');
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + int.Parse(nums[i].Trim());
            }
            Console.WriteLine("sum="+sum);

        }
    }

