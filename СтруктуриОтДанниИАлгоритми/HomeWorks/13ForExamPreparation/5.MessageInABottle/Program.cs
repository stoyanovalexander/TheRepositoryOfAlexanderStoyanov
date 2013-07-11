using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static string message;
        static List<KeyValuePair<char, string>> chiphers = new List<KeyValuePair<char, string>>();

        static void Main(string[] args)
        {
            message = Console.ReadLine();
            string chipher = Console.ReadLine();
            char key = char.MinValue;
            StringBuilder value = new StringBuilder();

            for (int i = 0; i < chipher.Length; i++)
            {
                if (chipher[i] >= 'A' && chipher[i] <= 'Z')
                {
                    if (key != char.MinValue)
                    {
                        chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                        value.Clear();
                    }
                    key = chipher[i];
                }

                else
                {
                    value.Append(chipher[i]);
                }
            }

            if (key != char.MinValue)
            {
                chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                value.Clear();
            }

            Solve(0,new StringBuilder());
            Console.WriteLine(solutions.Count);
            solutions.Sort();

            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }

        static List<string> solutions = new List<string>();

        static void Solve(int secretMessageIndex, StringBuilder sb)
        {
            if (secretMessageIndex == message.Length)
            {
                solutions.Add(sb.ToString());
                //return;
            }

            foreach (var chipher in chiphers)
            {
                if (message.Substring(secretMessageIndex).StartsWith(chipher.Value))
                {
                    sb.Append(chipher.Key);
                    Solve(secretMessageIndex + chipher.Value.Length, sb);
                    sb.Length--;
                }
            }
        }
    }

