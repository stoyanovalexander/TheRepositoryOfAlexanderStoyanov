using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class MainProgram
    {
        static void Main()
        {
            HashTable<string, int> myPeopleAge = new HashTable<string, int>();

            Console.WriteLine("MY PEOPLE");
            myPeopleAge.Add("Siabonga", 20);
            myPeopleAge.Add("Huren", 21);
            myPeopleAge["Filip"] = 22;
            myPeopleAge["Garo"] = 18;
            Console.WriteLine("count="+ myPeopleAge.Count());
            foreach (var item in myPeopleAge)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("MY PEOPLE AFTER REMOVE FILIP AND GARO");
            myPeopleAge.Remove("Filip");
            myPeopleAge.Remove("Garo");
            Console.WriteLine("count="+myPeopleAge.Count());
            foreach (var item in myPeopleAge)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("ONLY THE KEYS");
            List<string> myKeys = myPeopleAge.Keys;
            for (int i = 0; i < myKeys.Count; i++)
            {
                Console.WriteLine(myKeys[i]);
            }

            Console.WriteLine();
            Console.Write("Find Siabonga age: ");
            Console.Write(myPeopleAge.Find("Siabonga"));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("AFTER CLEAR COMAND");
            myPeopleAge.Clear();
            Console.WriteLine("count="+myPeopleAge.Count());
            Console.WriteLine();

            //Console.Write("Find Oncho(I do not have Oncho) age: ");
            //Console.Write(myPeopleAge.Find("Oncho"));
        }
    }
