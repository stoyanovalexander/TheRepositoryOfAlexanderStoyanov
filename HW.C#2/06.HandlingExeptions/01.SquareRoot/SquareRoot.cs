using System;
    class SquareRoot
    {
        static void FindingNegatives(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException("Invalid number!");
            }
        }
        static void Main()
        {
            Console.Write("Enter INTEGER number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                double squareRoot = Math.Sqrt(number);
                FindingNegatives(number);
                Console.WriteLine("the squarea root of {0}={1}", number, squareRoot);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid number!");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }

