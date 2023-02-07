using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Smallest();
        }

        static void Smallest()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] funcArray= { a, b, c };
            int smallest = a;

            for (int i = 0; i < funcArray.Length; i++)
            {
                for (int j = i+1; j < funcArray.Length; j++)
                {
                    if (funcArray[j] < smallest)
                    {
                        smallest = funcArray[j];
                    }
                }
            }
            Console.WriteLine(smallest);
        }
    }
}


