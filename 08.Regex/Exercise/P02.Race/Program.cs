using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> leaderboard = new Dictionary<string, int>();
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var participant in participants)
            {
                leaderboard.Add(participant, 0);
            }

            string patternLetters = @"[a-zA-Z]";
            string patternDigits = @"\d";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection letters = Regex.Matches(input, patternLetters);
                MatchCollection digits = Regex.Matches(input, patternDigits);
                string name = string.Empty;
                int sum = 0;

                foreach (Match match in letters)
                {
                    name += match.Value;
                }
                foreach (Match digit in digits)
                {
                    sum += int.Parse(digit.ToString());
                }

                if (leaderboard.ContainsKey(name))
                {
                    leaderboard[name] += sum;
                }

                input = Console.ReadLine();
            }

            int counter = 0;

            foreach (var participant in leaderboard
                         .OrderByDescending(x => x.Value))
            {
                switch (counter)
                {
                    case 0:
                        Console.WriteLine($"{counter + 1}st place: {participant.Key}");
                        break;
                    case 1:
                        Console.WriteLine($"{counter + 1}nd place: {participant.Key}");
                        break;
                    case 2:
                        Console.WriteLine($"{counter + 1}rd place: {participant.Key}");
                        break;
                }

                counter++;

                if (counter == 4)
                {
                    break;
                }
            }
        }
    }
}
