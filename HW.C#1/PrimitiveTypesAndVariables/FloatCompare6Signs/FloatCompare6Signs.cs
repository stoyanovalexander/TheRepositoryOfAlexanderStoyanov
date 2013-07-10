using System;
    class FloatCompare6Signs
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            float b = float.Parse(Console.ReadLine());
            float difference = Math.Abs(a - b);
            Console.WriteLine(a+"="+b+"  "+(difference<=0.000001));
        }
    }

