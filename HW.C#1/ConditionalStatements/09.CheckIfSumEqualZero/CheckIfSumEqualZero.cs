using System;
    class CheckIfSumEqualZero
    {
        static void Main()
        {
            Console.Write("Enter number  a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number  b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number  c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter number  d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter number  e=");
            int e = int.Parse(Console.ReadLine());
            for(int caseNumber=0;caseNumber<=25;caseNumber++)
            // the number of combinations=number of cases=(number of combinations with 2 numbers)+(number of combinations with 3 numbers)+
            // +(number of combinations with 4 numbers)+(number of combinations with 5 numbers)
            {
                switch (caseNumber)
                {
                        // (The number of the combinations with 2 numbers)=5!/(2!*(5-2)!)=(5*4*3!)/(2!*3!)= 10
                    case 0:
                        if ((a + b) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0",a,b); break;
                        }
                    case 1:
                        if ((a + c) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", a, c); break;
                        }
                    case 2:
                        if ((a + d) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", a, d); break;
                        }
                    case 3:
                        if ((a + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", a, e); break;
                        }
                    case 4:
                        if ((b+c) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", b, c); break;
                        }
                    case 5:
                        if ((b+d) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", b, d); break;
                        }
                    case 6:
                        if ((b+e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", b, e); break;
                        }
                    case 7:
                        if ((c + d) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", c, d); break;
                        }
                    case 8:
                        if ((c + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", c, e); break;
                        }
                    case 9:
                        if ((d + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})=0", d, e); break;
                        }

                        // (The number of combinations with 3 numbers)=5!/(3!*(5-3)!)=(5*4*3!)/(3!*2!)=(5*4)/2= 10
                    case 10:
                        if ((a + b + c) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", a, b,c); break;
                        }
                    case 11:
                        if ((a + b + d) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", a, b,d); break;
                        }
                    case 12:
                        if ((a + b + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", a, b,e); break;
                        }
                    case 13:
                        if ((a + c + d) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", a, c, d); break;
                        }
                    case 14:
                        if ((a + c + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", a, c, e); break;
                        }
                    case 15:
                        if ((a + d + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", a, d, e); break;
                        }
                    case 16:
                        if ((b + c + d) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", b, c, d); break;
                        }
                    case 17:
                        if ((b + c + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", b, c, e); break;
                        }
                    case 18:
                        if ((b + d + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", b, d, e); break;
                        }
                    case 19:
                        if ((c + d + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})=0", c, d, e); break;
                        }

                        // (The number of the combinations with 4 numbers)=5!/(4!*(5-4)!)=(5*4!)/4!= 5
                    case 20:
                        if ((a + b + c +d) != 0) // Without "e"
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})+({3})=0", a, b, c, d); break;
                        }
                    case 21:
                        if ((a + b + c + e) != 0) // Without "d"
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})+({3})=0", a, b, c, e); break;
                        }
                    case 22:
                        if ((a + b + d + e) != 0) // Without "c"
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})+({3})=0", a, b, d, e); break;
                        }
                    case 23:
                        if ((a + c + d + e) != 0) // Without "b"
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})+({3})=0", a, c, d, e); break;
                        }
                    case 24:
                        if ((b + c + d + e) != 0) // Without "a"
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})+({3})=0", b, c, d, e); break;
                        }

                        // (The of the combinations with 5 numbers)=5!/(5!*(5-5)!)=5!/5!= 1
                    case 25:
                        if ((a + b + c + d + e) != 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("({0})+({1})+({2})+({3})+({4})=0",a , b, c, d, e); break;
                        }

                    default:
                        Console.WriteLine("There are some mistake"); break;
                }
            }
        }
    }

