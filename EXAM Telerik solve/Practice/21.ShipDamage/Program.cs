using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            int Sx1 = int.Parse(Console.ReadLine());
            int Sy1 = int.Parse(Console.ReadLine());
            int Sx2 = int.Parse(Console.ReadLine());
            int Sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int Cx1 = int.Parse(Console.ReadLine());
            int Cy1 = int.Parse(Console.ReadLine());
            int Cx2 = int.Parse(Console.ReadLine());
            int Cy2 = int.Parse(Console.ReadLine());
            int Cx3 = int.Parse(Console.ReadLine());
            int Cy3 = int.Parse(Console.ReadLine());

            // Solve
            if (Sx1 > Sx2)
            {
                int tr1 = Sx2;
                Sx2 = Sx1;
                Sx1 = tr1;
            }
            if (Sy1 > Sy2)
            {
                int tr2 = Sy2;
                Sy2 = Sy1;
                Sy1 = tr2;
            }
            int HPx1 = Cx1;
            int HPx2 = Cx2;
            int HPx3 = Cx3;
            int HPy1 = H + (H - Cy1);
            int HPy2 = H + (H - Cy2);
            int HPy3 = H + (H - Cy3);
            int d = 0;
            if (((HPx1 == Sx1) || (HPx1 == Sx2)) && ((HPy1 > Sy1) && (HPy1 < Sy2)) ||
                ((HPx2 == Sx1) || (HPx2 == Sx2)) && ((HPy2 > Sy1) && (HPy2 < Sy2)) ||
                ((HPx3 == Sx1) || (HPx3 == Sx2)) && ((HPy3 > Sy1) && (HPy3 < Sy2)))
            {
                d = d + 50;
            }
            if (((HPy1 == Sy1) || (HPy1 == Sy2)) && ((HPx1 > Sx1) && (HPx1 < Sx2)) ||
                ((HPy2 == Sy1) || (HPy2 == Sy2)) && ((HPx2 > Sx1) && (HPx2 < Sx2)) ||
                ((HPy3 == Sy1) || (HPy3 == Sy2)) && ((HPx3 > Sx1) && (HPx3 < Sx2)))
            {
                d = d + 50;
            }
            if (((HPx1 == Sx1) && (HPy1 == Sy1)) || ((HPx1 == Sx2) && (HPy1 == Sy1)) || ((HPx1 == Sx1) && (HPy1 == Sy2)) || ((HPx1 == Sx2) && (HPy1 == Sy2)))
            {
                d = d + 25;
            }
            if (((HPx2 == Sx1) && (HPy2 == Sy1)) || ((HPx2 == Sx2) && (HPy2 == Sy1)) || ((HPx2 == Sx1) && (HPy2 == Sy2)) || ((HPx2 == Sx2) && (HPy2 == Sy2)))
            {
                d = d + 25;
            }
            if (((HPx3 == Sx1) && (HPy3 == Sy1)) || ((HPx3 == Sx2) && (HPy3 == Sy1)) || ((HPx3 == Sx1) && (HPy3 == Sy2)) || ((HPx3 == Sx2) && (HPy3 == Sy2)))
            {
                d = d + 25;
            }
            if (((HPx1 > Sx1) && (HPx1 < Sx2)) && ((HPy1 > Sy1) && (HPy1 < Sy2)))
            {
                d = d + 100;
            }
            if (((HPx2 > Sx1) && (HPx2 < Sx2)) && ((HPy2 > Sy1) && (HPy2 < Sy2)))
            {
                d = d + 100;
            }
            if (((HPx3 > Sx1) && (HPx3 < Sx2)) && ((HPy3 > Sy1) && (HPy3 < Sy2)))
            {
                d = d + 100;
            }
            Console.WriteLine(d+"%");
        }
    }

