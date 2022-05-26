using System;
using System.Linq;

namespace P03_Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    first[i] = currentNumbers[0];
                    second[i] = currentNumbers[1];
                }
                else
                {
                    first[i] = currentNumbers[1];
                    second[i] = currentNumbers[0];
                }
            }
            Console.WriteLine(String.Join(' ', first));
            Console.WriteLine(String.Join(' ', second));
        }
    }
}
