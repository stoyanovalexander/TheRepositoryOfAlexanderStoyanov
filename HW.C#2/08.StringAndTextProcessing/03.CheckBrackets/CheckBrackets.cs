using System;
using System.Text;
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression with brackets: ");
            string expression = Console.ReadLine();
            int count=0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    count++;
                }
                if(expression[i]==')')
                {
                    count--;
                }
                if (count < 0)
                {
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Example of corect expression: " + expression);
            }
            else
            {
                Console.WriteLine("Example of incorect expression: " + expression);
            }
        }
    }

