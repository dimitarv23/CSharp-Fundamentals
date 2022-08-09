using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\:]{2}|[\*]{2})(?<emojiName>[A-Z][a-z]{2,})\1";

            long threshold = CalculateThreshold(input);
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> coolEmojis = new List<string>();

            foreach (Match match in matches)
            {
                string currEmojiName = match.Groups["emojiName"].Value;
                int sumOfASCIICodes = CalculateSumOfASCIICodes(currEmojiName);

                if (sumOfASCIICodes > threshold)
                {
                    coolEmojis.Add(match.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (string emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }
        }

        static long CalculateThreshold(string input)
        {
            long threshold = 1;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    threshold *= int.Parse(c.ToString());
                }
            }

            return threshold;
        }

        static int CalculateSumOfASCIICodes(string emojiName)
        {
            int sumOfASCIICodes = 0;

            foreach (char c in emojiName)
            {
                sumOfASCIICodes += c;
            }

            return sumOfASCIICodes;
        }
    }
}
