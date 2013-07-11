using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExtractOddNumApearanced
    {
        static void Main()
        {
            string[] someArrayOfStrings = { "Siabonga", "Huren", "Docun", "Docun", "Siabonga", "Siabonga"
                                              , "Docun", "Ivan", "Ivan","Sandocan" };
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var someString in someArrayOfStrings)
            {
                int count = 0;
                if (dictionary.ContainsKey(someString))
                {
                    count = dictionary[someString];
                }
                dictionary[someString] = count + 1;
            }

            // Print the array with the strings
            Console.Write("{");
            for (int i = 0; i < someArrayOfStrings.Length-1; i++)
            {
                Console.Write(someArrayOfStrings[i]);
                Console.Write(", ");
            }
            Console.Write(someArrayOfStrings[someArrayOfStrings.Length-1]);
            Console.Write("}");
            Console.Write("->");

            //Print the repeated odd number of times strings
            Console.Write("{");
            StringBuilder oddOccurences = new StringBuilder();
            foreach (KeyValuePair<string, int> item in dictionary)
            {
                if (item.Value % 2 == 1)
                {
                    oddOccurences.Append(item.Key);
                    oddOccurences.Append(", ");
                }
            }
            //int length=oddOccurences.Length;
            string oddOccurAsString=oddOccurences.ToString();
            int len=oddOccurAsString.Length;
            string oddOccurNoEndComa=oddOccurAsString.Substring(0, len - 2);

            Console.Write(oddOccurNoEndComa);
            Console.Write("}");
            Console.WriteLine();
        }
    }

