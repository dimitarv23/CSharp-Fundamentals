using System;
using System.Collections.Generic;

namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsAndSynonyms.ContainsKey(word))
                {
                    wordsAndSynonyms.Add(word, new List<string>());
                }

                wordsAndSynonyms[word].Add(synonym);
            }

            foreach (var item in wordsAndSynonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
