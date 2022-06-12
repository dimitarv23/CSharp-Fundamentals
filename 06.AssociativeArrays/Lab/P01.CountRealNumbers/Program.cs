using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            Dictionary<int, int> occurrencies = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (occurrencies.ContainsKey(num))
                {
                    occurrencies[num]++;
                }
                else
                {
                    occurrencies.Add(num, 1);
                }
            }

            foreach (var item in occurrencies.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
