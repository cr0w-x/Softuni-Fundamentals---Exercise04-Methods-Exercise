using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            decimal factorialDivision = (decimal)Factorial(a) / (decimal)Factorial(b);
            Console.WriteLine($"{factorialDivision:f2}");
        }
        static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * (Factorial(n - 1));
            }
        }
    }
}
