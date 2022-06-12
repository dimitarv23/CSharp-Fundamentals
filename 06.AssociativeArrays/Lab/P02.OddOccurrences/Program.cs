using System;
using System.Collections.Generic;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsAndCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCaseWord = word.ToLower();

                if (wordsAndCounts.ContainsKey(lowerCaseWord))
                {
                    wordsAndCounts[lowerCaseWord]++;
                }
                else
                {
                    wordsAndCounts.Add(lowerCaseWord, 1);
                }
            }

            foreach (var item in wordsAndCounts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
