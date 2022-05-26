using System;
using System.Linq;

namespace P04FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startingArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = startingArray.Length / 4;

            int[] upperRightArray = new int[k];
            int[] upperLeftArray = new int[k];
            int[] lowerArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                upperLeftArray[i] = startingArray[i];
            }
            for (int i = k; i < 3 * k; i++)
            {
                lowerArray[i - k] = startingArray[i];
            }
            for (int i = 3 * k; i < 4 * k; i++)
            {
                upperRightArray[i - 3 * k] = startingArray[i];
            }

            Array.Reverse(upperLeftArray);
            Array.Reverse(upperRightArray);

            for (int i = 0; i < 2 * k; i++)
            {
                if (i < k)
                {
                    Console.Write($"{upperLeftArray[i] + lowerArray[i]} ");
                }
                else
                {
                    Console.Write($"{upperRightArray[i - k] + lowerArray[i]} ");
                }
            }
        }
    }
}
