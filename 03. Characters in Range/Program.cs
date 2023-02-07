using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharsInRange(a, b);
        }

        private static void CharsInRange(char firstChar, char secondChar)
        {
            if (firstChar < secondChar)
            {
                for (char a = (char)(firstChar + 1); a < secondChar; a++)
                {
                    Console.Write(a + " ");
                }
            }
            else
            {
                for (char a = (char)(secondChar + 1); a < firstChar; a++)
                {
                    Console.Write(a + " ");
                }
            }
        }
    }
}
