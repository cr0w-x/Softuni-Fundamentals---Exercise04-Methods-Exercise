using System;
using System.Collections.Generic;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleTwo(input));
        }
        static string MiddleTwo(string input)
        {
            char[]chars = input.ToCharArray();
            int counter = 0;
            bool ifEven = false;
            var middleChars = new List<string>();
            for (int i = 0; i < chars.Length; i++)
            {
                counter++;
            }
            if (counter %2 == 0)
            {
                ifEven = true;
            }
            if (ifEven)
            {
                middleChars.Add(chars[counter / 2 - 1].ToString());
                middleChars.Add(chars[counter / 2].ToString());
            }
            else
            {
                middleChars.Add(chars[counter / 2].ToString());
            }
            return (string.Join("",middleChars));
        }
    }
}
