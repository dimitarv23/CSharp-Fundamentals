using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([@#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> mirrorWords = new List<string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                if (firstWord == Reverse(secondWord))
                {
                    mirrorWords.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are: ");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            }
        }

        static string Reverse(string word)
        {
            StringBuilder reverse = new StringBuilder();

            for (int i =  word.Length - 1; i >= 0; i--)
            {
                reverse.Append(word[i]);
            }

            return reverse.ToString();
        }
    }
}
