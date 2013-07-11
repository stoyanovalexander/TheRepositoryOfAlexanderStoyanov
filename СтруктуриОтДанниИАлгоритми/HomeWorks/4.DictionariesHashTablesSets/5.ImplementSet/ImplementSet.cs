using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ImplementSet
    {
        static void Main(string[] args)
        {
            OurHashedSet<int> siabongasMarks = new OurHashedSet<int>();
            siabongasMarks.Add(4);
            siabongasMarks.Add(5);
            siabongasMarks.Add(3);
            Console.WriteLine("The marks of Siabonga");
            foreach (var mark in siabongasMarks)
            {
                Console.WriteLine(mark);
            }
            Console.WriteLine("Count of Siabonga marks is: "+siabongasMarks.Count());
            Console.WriteLine();

            Console.WriteLine("Siabonga mark 4 FIND: "+siabongasMarks.Find(4));
            Console.WriteLine();

            siabongasMarks.Remove(4);
            Console.WriteLine("Count after remove Siabonga mark(4): "+siabongasMarks.Count());
            Console.WriteLine();
            
            siabongasMarks.Clear();
            Console.WriteLine("Count after clear Siabonga marks: "+siabongasMarks.Count());
            Console.WriteLine();

        }
    }

