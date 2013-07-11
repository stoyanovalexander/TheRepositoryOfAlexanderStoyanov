using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDefClasses2;

namespace DemoDefClasses2
{
    class PRGRAM
    {
        static void Main(string[] args)
        {
            // STATIC MEMBERS
            Console.WriteLine(SqrtPrecalculated.GetSqrt(3423));

            // STRUCTURES
            Square square = new Square(new Point() { X = 5, Y = 6 }, 8, new Color() { RedValue = 32, GreenValue = 76, BlueValue = 111 },
                new Color() { RedValue = 22, GreenValue = 33, BlueValue = 44 }, Edges.Straight);
            Console.WriteLine(square);

            square.Edges = Edges.Straight;
            square.BorderColor = new Color() { RedValue = 0, GreenValue = 8, BlueValue = 44 };
            Point location = square.Location;
            location.X += 10;
            square.Location = location;
            Console.WriteLine(square);

            // GENERIC CLASSES
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine("Number of elements: {0}",intList.Count);
            for (int i = 0; i < intList.Count; i++)
            {
                int element = intList[i];
                Console.WriteLine(element);
            }
            Console.WriteLine();

            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("C#");
            stringList.Add("PHP");
            stringList.Add("Java");
            Console.WriteLine("Number of elm is {0}",stringList.Count);
            for (int i = 0; i < stringList.Count; i++)
            {
                string element = stringList[i];
                Console.WriteLine(element);
            }
        
            // GENERIC METHOD
            int k = 5;
            int j = 7;
            int min = GenericMethod.Min<int>(k, j);
            Console.WriteLine("Min({0},{1})={2}",k,j,min);

            string firstStr= "Rakya";
            string secondStr= "Beer";
            string minStr = GenericMethod.Min<string>(firstStr, secondStr);
            Console.WriteLine("Min({0},{1})={2}",firstStr,secondStr,minStr);

            //Point p1 = new Point();
            //Point p2 = new Point();
            //Point minPoint = GenericMethod.Min<Point>(p1, p2);
            // Will not compile

            // INDEXERS
            BitArray32 bits = new BitArray32();
            bits[1] = 1;
            bits[5] = 1;
            bits[22] = 1;
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("bit[{0}]={1}",i,bits[i]);
            }
            Console.WriteLine();
            Console.Write("bits=");
            for (int i = 0; i < 31; i++)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();

            // ATTRIBUTES
            UsingAttributes.ShowMessageBox(0,"Some text"," caption",0);

            // GENERIC CONSTRAINT CLASSES
            GenericConstraintClass<TestClass1> test1 = new GenericConstraintClass<TestClass1>();

            // OPERATORS OVERLOADING
            Fraction f1 = (double)1 / 4;
            Console.WriteLine("f1 = {0}", f1);
            Fraction f2 = (double)7 / 10;
            Console.WriteLine("f2 = {0}", f2);
            Console.WriteLine("-f1 = {0}", -f1);
            Console.WriteLine("f1 + f2 = {0}", f1 + f2);
            Console.WriteLine("f1 - f2 = {0}", f1 - f2);
            Console.WriteLine("f1 * f2 = {0}", f1 * f2);
            Console.WriteLine("f1 / f2 = {0}", f1 / f2);
            Console.WriteLine("f1 / f2 as double = {0}", (double)(f1 / f2));
            Console.WriteLine("-(f1+f2)*(f1-f2/f1) = {0}", -(f1 + f2) * (f1 - f2 / f1));
            Console.WriteLine("++f1 = {0}", ++f1);


        }
    }
}
