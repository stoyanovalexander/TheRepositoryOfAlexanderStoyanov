using System;
    class CalculateTriangleSurface
    {
        static void SurfaceFinding(int side, int altitude)
        {
            double surface = (side * altitude) / 2.0;
            Console.Write(surface);
        }

        static void SurfaceFinding(int sideOne, int sideTwo, int sideThree)
        { 
            double halfPerimeter=(sideOne+sideTwo+sideThree)/2.0;
            double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - sideTwo) * 
                (halfPerimeter - sideThree));
            Console.Write(surface);
        }

        static void SurfaceFinding(int sideOne, int sideTwo, double angle)
        {
            double degAngle = angle * Math.PI / 180;
            double surface = (sideOne * sideTwo * Math.Sin(degAngle))/2;
            Console.Write(surface);
        }
        static void Main()
        {
            Console.Write("firstSideOne=");
            int firstSideOne = int.Parse(Console.ReadLine());
            Console.Write("firstAltitude=");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("secondSideOne=");
            int secondSideOne = int.Parse(Console.ReadLine());
            Console.Write("secondSideTwo=");
            int secondSideTwo = int.Parse(Console.ReadLine());
            Console.Write("secondSideThree=");
            int secondSidethree = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("thirdSideOne=");
            int thirdSideOne = int.Parse(Console.ReadLine());
            Console.Write("thirdSideTwo=");
            int thirdSideTwo = int.Parse(Console.ReadLine());
            Console.Write("thirdAngle=");
            double thirdAngle = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Side and altitude: ");
            SurfaceFinding(firstSideOne, firstAltitude);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Three sides: ");
            SurfaceFinding(secondSideOne,secondSideTwo,secondSidethree);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Two sides and angle: ");
            SurfaceFinding(thirdSideOne,thirdSideTwo,thirdAngle);
            Console.WriteLine();
        }
    }

