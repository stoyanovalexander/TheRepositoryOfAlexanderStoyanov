using System;
    class NullTypes
    {
        static void Main()
        {
            int? i = null;
            double? j = null;
            Console.WriteLine(i);//Console does not show a thing
            Console.WriteLine(j);//Console does not show a thing
            i = i + 5;
            j = j + 5.0;
            Console.WriteLine(i);//Console does not show a thing
            Console.WriteLine(j);//Console does not show a thing
        }
    }

