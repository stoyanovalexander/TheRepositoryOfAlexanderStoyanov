using System;
    class SomeOfTreeTasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("theSwitch=1:Found reversed number of entered one");
            Console.WriteLine("theSwitch=2:Found the overage sum of entered numbers");
            Console.WriteLine("theSwitch=3:Found the solve of a*x+b=0");
            int theSwitch = int.Parse(Console.ReadLine());
            if (theSwitch == 1)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                Reversing(number);
            }
            if (theSwitch == 2)
            {
                Console.WriteLine("Enter string with numbers with intervals between them: ");
                string strNumbers = Console.ReadLine();
                CountOverageSum(strNumbers);
                
            }
            if (theSwitch == 3)
            {
                Console.Write("Enter a=");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b=");
                int b = int.Parse(Console.ReadLine());
                SolveEquation(a, b);
            }

        }

        static void Reversing(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("You must enter positiv number!");
            }
            int forChange=0;
            int reverse = 0;
            while (num != 0)
            {
                 forChange= num % 10;
                 reverse = reverse * 10 + forChange;
                 num = num / 10;
            }
            Console.WriteLine("   reversed is:  "+reverse);
        }

        static void CountOverageSum(string withNumbers)
        {
            if (withNumbers == null)
            {
                Console.WriteLine("The sequence sould not be empty");
            }
            else
            {
                string[] nums = withNumbers.Split(' ');
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum = sum + int.Parse(nums[i].Trim());
                }
                double overageSum = (double)(sum) / (double)(nums.Length);
                Console.WriteLine("overageSum=" + overageSum);
            }
        }

        static void SolveEquation(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine("a should not be equal to zero");
            }
            else
            {
                double x = -((double)a / (double)b);
                Console.WriteLine("x="+x);
            }
        }
    }

