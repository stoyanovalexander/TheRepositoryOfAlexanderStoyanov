/* Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new 
 * StringBuilder and has the same functionality as Substring in the class String.
 */

using System;
using System.Text;


public static class StringBulderSubstring
{
    public static StringBuilder Substring(this StringBuilder text, int index, int lenght)
    {
        if (text.Length - lenght >= 0)
        {
            text.Remove(0, index);
            text.Remove(lenght, text.Length - lenght);
            return text;
        }
        else
        {
            throw new ArgumentOutOfRangeException("The length of Substring must be less or equal to lenght of StringBuilder");
        }
    }

    static void Main()
    {
        StringBuilder text = new StringBuilder();
        text.Append("Asiaasiaasia");
        Console.WriteLine(text.Substring(1, 2));
    }
}

