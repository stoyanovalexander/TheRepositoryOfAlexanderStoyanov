using System;
    class Program
    {
        static void Main(string[] args)
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());

            int minSx = Math.Min(sx1,sx2);
            int maxSx = Math.Max(sx1, sx2);
            int minSy = Math.Min(sy1, sy2);
            int maxSy = Math.Max(sy1, sy2);

            // Hit Points
            cy1 = 2 * h - cy1;
            cy2 = 2 * h - cy2;
            cy3 = 2 * h - cy3;

            int damage = 0;

            // Corners
            if (((cx1 == minSx) && (cy1 == minSy)) ||
                ((cx1 == minSx) && (cy1 == maxSy)) ||
                ((cx1 == maxSx) && (cy1 == minSy)) ||
                ((cx1 == maxSx) && (cy1 == maxSy)))
            {
                damage = damage + 25;
            }
            if (((cx2 == minSx) && (cy2 == minSy)) ||
                ((cx2 == minSx) && (cy2 == maxSy)) ||
                ((cx2 == maxSx) && (cy2 == minSy)) ||
                ((cx2 == maxSx) && (cy2 == maxSy)))
            {
                damage = damage + 25;
            }
            if (((cx3 == minSx) && (cy3 == minSy)) ||
                ((cx3 == minSx) && (cy3 == maxSy)) ||
                ((cx3 == maxSx) && (cy3 == minSy)) ||
                ((cx3 == maxSx) && (cy3 == maxSy)))
            {
                damage = damage + 25;
            }

            // Sides
            if(((cx1==minSx)&&(cy1>minSy)&&(cy1<maxSy))||
                ((cx1==maxSx)&&(cy1>minSy)&&(cy1<maxSy))||
                ((cy1==minSy)&&(cx1>minSx)&&(cx1<maxSx))||
                ((cy1==maxSy)&&(cx1>minSx)&&(cx1<maxSx)))
            {
                damage=damage+50;
            }
            if(((cx2==minSx)&&(cy2>minSy)&&(cy2<maxSy))||
                ((cx2==maxSx)&&(cy2>minSy)&&(cy2<maxSy))||
                ((cy2==minSy)&&(cx2>minSx)&&(cx2<maxSx))||
                ((cy2==maxSy)&&(cx2>minSx)&&(cx2<maxSx)))
            {
                damage=damage+50;
            }
            if(((cx3==minSx)&&(cy3>minSy)&&(cy3<maxSy))||
                ((cx3==maxSx)&&(cy3>minSy)&&(cy3<maxSy))||
                ((cy3==minSy)&&(cx3>minSx)&&(cx3<maxSx))||
                ((cy3==maxSy)&&(cx3>minSx)&&(cx3<maxSx)))
            {
                damage=damage+50;
            }

            // In side
            if ((cx1 > minSx) && (cx1 < maxSx) && (cy1 > minSy) && (cy1 < maxSy))
            {
                damage = damage + 100;
            }
            if ((cx2 > minSx) && (cx2 < maxSx) && (cy2 > minSy) && (cy2 < maxSy))
            {
                damage = damage + 100;
            }
            if ((cx3 > minSx) && (cx3 < maxSx) && (cy3 > minSy) && (cy3 < maxSy))
            {
                damage = damage + 100;
            }


            Console.WriteLine(damage+"%");
        }
    }

