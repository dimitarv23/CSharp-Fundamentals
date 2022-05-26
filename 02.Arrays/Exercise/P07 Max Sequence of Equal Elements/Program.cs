using System;
using System.Linq;

namespace P07_Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentStreak = 0;
            int longestStreak = 0;
            int bestIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 0;
                }

                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                    bestIndex = i;
                }
            }

            for (int i = 0; i <= longestStreak; i++)
            {
                Console.Write($"{numbers[bestIndex]} ");
            }
        }
    }
}
