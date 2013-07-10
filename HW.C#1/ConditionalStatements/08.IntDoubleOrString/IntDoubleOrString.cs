using System;
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.Write("Enter case number: ");
            byte cases = byte.Parse(Console.ReadLine());
            switch (cases)
            { 
                case 1:
                    Console.Write("Enter value of the int variable: ");
                    int intVar = int.Parse(Console.ReadLine());
                    intVar = intVar + 1;
                    Console.WriteLine("intVar+1="+intVar);break;
                case 2:
                    Console.Write("Enter value of the double variable: ");
                    double doubleVar = double.Parse(Console.ReadLine());
                    doubleVar = doubleVar +1;
                    Console.WriteLine("doubleVar+1="+doubleVar);break;
                case 3:
                    Console.Write("Enter value of the string variable: ");
                    string stringVar = Console.ReadLine();
                    stringVar = stringVar + "*";
                    Console.WriteLine("stringVar*= "+stringVar);break;
                default:
                    Console.WriteLine("Must enter value 1,2 or 3 for case number: ");break;
            }
        }
    }

