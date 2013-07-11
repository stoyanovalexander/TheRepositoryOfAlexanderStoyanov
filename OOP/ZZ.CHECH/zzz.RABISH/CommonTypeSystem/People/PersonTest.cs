using System;

namespace People
{
    /// <summary>
    /// Tests Person functionality.
    /// </summary>
    public class PersonTest
    {
        /// <summary>
        /// Main entry point of PersonTest.
        /// </summary>
        public static void Main()
        {
            // Create some people
            Person pesho = new Person("Pesho", 20);
            Person ivan = new Person("Ivan");

            // Print data
            Console.WriteLine(pesho);
            Console.WriteLine(ivan);
        }
    }
}