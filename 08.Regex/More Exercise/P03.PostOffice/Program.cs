using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03.PostOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> output = new List<string>();

            string[] textParts = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);
            string firstPart = textParts[0];
            string secondPart = textParts[1];
            string thirdPart = textParts[2];

            //Configure the first part:
            string capitalLettersPattern = @"([#$%*&])(?<capitals>[A-Z]+)\1";
            Match capitalsMatch = Regex
                .Match(firstPart, capitalLettersPattern);
            string capitalLetters = capitalsMatch.Groups["capitals"].Value;
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char letter in capitalLetters)
            {
                //The dictionary holds information ([capital letter] = count of following letters)
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 0);
                }
            }

            //Configure the second part:
            string wordsInfoPattern = @"\d{2}:\d{2}";
            //wordsInfo gets all the matches (e.g. "65:03", "79:01" etc.)
            MatchCollection wordsInfo = Regex.Matches(secondPart, wordsInfoPattern);

            foreach (Match match in wordsInfo)
            {
                //currWordInfo splits the current match in the format ("65:03" -> ["65", "03"])
                string[] currWordInfo = match
                    .Value.Split(':');
                int asciiCode = int.Parse(currWordInfo[0]);
                int followingLetters = int.Parse(currWordInfo[1]);

                if (asciiCode < 65 || asciiCode > 90 || followingLetters < 1 || followingLetters > 20)
                {
                    //The given ascii code is not a capital letter => go on with the next one
                    //The given count of following letters isn't between 1 and 20 => go on with the next one
                    continue;
                }

                if (letters.ContainsKey((char)asciiCode))
                {
                    //In the dictionary, the ascii code letter exists => add as value to the given capital letter - the count of letters that come after it
                    letters[(char)asciiCode] = followingLetters;
                }
            }

            //Configure the third part
            string wordsPattern = @"\b[A-Z]+[^ ]*";
            MatchCollection wordsMatches = Regex.Matches(thirdPart, wordsPattern);

            foreach (Match word in wordsMatches)
            {
                string currWord = word.Value;
                char currWordCapitalLetter = currWord[0];

                if (letters.ContainsKey(currWordCapitalLetter))
                {
                    //followingLetters holds the letters after the capital one
                    string followingLetters = currWord.Substring(1);

                    if (followingLetters.Length == letters[currWordCapitalLetter])
                    {
                        //The count of following letters is equal to the given count from the first part => the word is what we are searching for => remove the capital letter from the dictionary
                        output.Add(currWord);
                        letters.Remove(currWordCapitalLetter);
                    }
                }
            }

            if (output.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, output));
            }
        }
    }
}
