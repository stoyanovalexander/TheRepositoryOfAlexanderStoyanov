using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RecoverMessage
{
    class RecoverMessage
    {
        static void Main(string[] args)
        {
            SortedSet<char> result = new SortedSet<char>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string message = Console.ReadLine();

                for (int j = 0; j < message.Length; j++)
                {
                    result.Add(message[j]);
                }
            }

            foreach (var someChar in result)
            {
                Console.Write(someChar);
            }
        }
    }
}
