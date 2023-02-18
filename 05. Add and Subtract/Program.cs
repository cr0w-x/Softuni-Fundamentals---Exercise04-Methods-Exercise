using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractNum(SumOfTwo(a,b),c));
        }
        static int SumOfTwo(int a, int b)
        {
            return a + b;
        }
        static int SubtractNum(int a, int b)
        {
            return a - b;
        }
    }
}
