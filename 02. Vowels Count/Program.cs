using System;
using System.Collections.Generic;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(NumberOfVowels(input));
        }

        static string NumberOfVowels(string input)
        {
            int total = 0;
            char[] chars = input.ToLower().ToCharArray();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < chars.Length; i++)
            {
                if (vowels.Contains(chars[i]))
                {
                    total++;
                }
            }            
            return total.ToString();
        }
    }
}
