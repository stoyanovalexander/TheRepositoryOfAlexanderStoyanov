using System;
    class DescedingOrder
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double small = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double middle = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double big = double.Parse(Console.ReadLine());
            double exchange;
            if ((small < middle)&&(small<big))
            {
                if (middle > big)
                {
                    exchange = middle;
                    middle = big;
                    big = exchange;
                }
            }
            else if ((small < middle)&&(small>=big))
            {
                exchange = small;
                small = big;
                big = middle;
                middle = exchange;
            }
            else if ((small >= middle)&&(small<big))
            {
                exchange = small;
                small = middle;
                middle = exchange;
            }
            else if ((small >= middle)&&(small>=big))
            {
                if (big < middle)
                {
                    exchange = small;
                    small = big;
                    big = exchange;
                }
                else
                {
                    exchange = small;
                    small = middle;
                    middle = big;
                    big = exchange;
                }
            }
            Console.WriteLine("The three numbers in DescedingOrder order: {0} ; {1} ; {2} ",big,middle,small);
        }
    }

