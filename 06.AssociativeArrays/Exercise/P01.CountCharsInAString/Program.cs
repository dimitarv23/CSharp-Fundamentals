using System;
using System.Collections.Generic;

namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charsAndCounts = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (charsAndCounts.ContainsKey(ch))
                {
                    charsAndCounts[ch]++;
                }
                else
                {
                    if (ch != ' ')
                    {
                        charsAndCounts.Add(ch, 1);
                    }
                }
            }

            foreach (var item in charsAndCounts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
