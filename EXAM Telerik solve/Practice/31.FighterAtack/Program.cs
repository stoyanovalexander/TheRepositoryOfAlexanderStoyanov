using System;
    class Program
    {
        static void Main(string[] args)
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine());
            int Py2 = int.Parse(Console.ReadLine());
            int Fx = int.Parse(Console.ReadLine());
            int Fy = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int minPx = Math.Min(Px1,Px2);
            int maxPx = Math.Max(Px1,Px2);
            int minPy = Math.Min(Py1, Py2);
            int maxPy = Math.Max(Py1, Py2);

            int xHit = Fx + D;
            int yHit = Fy;
            int xUpHit = Fx + D;
            int yUpHit = Fy+1;
            int xDownHit = Fx + D;
            int yDownHit = Fy-1;
            int xFrontHit = Fx + D+1;
            int yFrontHit = Fy;

            int damage = 0;
            if ((xHit >= minPx) && (xHit <= maxPx) && (yHit >= minPy) && (yHit <= maxPy))
            {
                damage = damage + 100;
            }
            if ((xUpHit >= minPx) && (xUpHit <= maxPx) && (yUpHit >= minPy) && (yUpHit <= maxPy))
            {
                damage = damage + 50;
            }
            if ((xDownHit >= minPx) && (xDownHit <= maxPx) && (yDownHit >= minPy) && (yDownHit <= maxPy))
            {
                damage = damage + 50;
            }
            if ((xFrontHit >= minPx) && (xFrontHit <= maxPx) && (yFrontHit >= minPy) && (yFrontHit <= maxPy))
            {
                damage = damage + 75;
            }
            Console.WriteLine(damage+"%");
        }
    }

