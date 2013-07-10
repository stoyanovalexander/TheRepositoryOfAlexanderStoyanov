using System;
    class GetMaxNumber
    {
        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        static void Main()
        {
            Console.Write("Enter firstNumber: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter secondNumber: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter thirdNumber: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Bigest number is: "+GetMax(GetMax(firstNumber,secondNumber),thirdNumber));
        }
    }

