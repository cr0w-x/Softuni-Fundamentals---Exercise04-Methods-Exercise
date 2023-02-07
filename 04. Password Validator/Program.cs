using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IsValidPwd(input);
        }

        static void IsValidPwd (string pwd )
        {
            char[] chars = pwd.ToCharArray();
            bool sixToTenSymbols = false;
            bool charIsDigitOrLetter = true;
            int atLeastTwoDigits = 0;
            string output = string.Empty;

            if (chars.Length >= 6 && chars.Length <= 10)
            {
                sixToTenSymbols = true;
            }

            foreach (char c in chars)
            {
                if (!char.IsDigit(c) && !char.IsLetter(c))
                {
                    charIsDigitOrLetter = false;
                }
            }

            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                {
                    atLeastTwoDigits++;
                }
            }

            if (!sixToTenSymbols)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            if (!charIsDigitOrLetter)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }

            if (atLeastTwoDigits < 2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }

            if (sixToTenSymbols && charIsDigitOrLetter && atLeastTwoDigits >= 2)
                Console.WriteLine($"Password is valid");
        }
    }
}
