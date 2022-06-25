using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.RageQuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[\D]+[1-9]+[\d]*";

            List<char> uniqueSymbols = new List<char>();
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder output = new StringBuilder();

            foreach (Match match in matches)
            {
                //Get the number (representing the repeats) by getting only the digits in the current match
                //Then get the text to repeat by getting everything int the current match except the digits and make all the letters upper-case
                int repeats = int.Parse(Regex.Match(match.Value, @"[\d]+").Value);
                string textToRepeat = Regex.Match(match.Value, @"[\D]+").Value.ToUpper();
                
                //Add all the symbols which don't exist in the symbol list (representing the characters used)
                uniqueSymbols.AddRange(textToRepeat
                    .Where(ch => !uniqueSymbols.Contains(ch)));

                for (int i = 0; i < repeats; i++)
                {
                    //Append the text n times (n => number of repeats given)
                    output.Append(textToRepeat.ToUpper());
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(output);
        }
    }
}
