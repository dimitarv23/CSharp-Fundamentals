using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"[^@\-!:>]*?@(?<planet>[A-Za-z]+)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?!(?<type>A|D)![^@\-!:>]*?->(?<soldiers>\d+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int count = 0;

                foreach (var sym in input.ToLower())
                {
                    if (sym == 's' || sym == 't' || sym == 'a' || sym == 'r')
                    {
                        count++;
                    }
                }

                StringBuilder sb = new StringBuilder();
                foreach (var sym in input)
                {
                    sb.Append((char)(sym - count));
                }

                string readyInput = sb.ToString();
                Match match = Regex.Match(readyInput, pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    int planetPopulation = int.Parse(match.Groups["population"].Value);
                    string attackType = match.Groups["type"].Value;
                    int soldiersCount = int.Parse(match.Groups["soldiers"].Value);

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets
                         .OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets
                         .OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
