using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            double average = 0;

            foreach (var number in numbers)
            {
                average += number;
            }

            average /= numbers.Length;
            Array.Sort(numbers);
            Array.Reverse(numbers);
            List<int> topFiveGreaterThanAverage = new List<int>();

            foreach(var number in numbers)
            {
                if (number > average)
                {
                    topFiveGreaterThanAverage.Add(number);
                }

                if (topFiveGreaterThanAverage.Count == 5)
                {
                    break;
                }
            }

            if (topFiveGreaterThanAverage.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", topFiveGreaterThanAverage));
            }
        }
    }
}
