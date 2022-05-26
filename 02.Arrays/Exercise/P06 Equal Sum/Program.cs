using System;
using System.Linq;

namespace P06_Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool areSumsEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];
                }
                for (int right = i + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    areSumsEqual = true;
                }
            }
            if (!areSumsEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
