using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.SantasSecretHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>[GNgn])!";
            List<string> childrenWithGifts = new List<string>();

            while (input != "end")
            {
                StringBuilder decryptedInput = new StringBuilder();

                foreach (char c in input)
                {
                    decryptedInput.Append((char)(c - n));
                }

                Match match = Regex.Match(decryptedInput.ToString(), pattern);
                if (match.Success)
                {
                    string behavior = match.Groups["behavior"].Value;

                    if (behavior.ToLower() == "g")
                    {
                        string childName = match.Groups["name"].Value;

                        if (!childrenWithGifts.Contains(childName))
                        {
                            childrenWithGifts.Add(childName);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (childrenWithGifts.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, childrenWithGifts));
            }
        }
    }
}
