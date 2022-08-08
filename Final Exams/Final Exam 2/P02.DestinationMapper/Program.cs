using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            string pattern = @"([=/])(?<destination>[A-Z][A-Za-z]{2,})\1";

            MatchCollection matches = Regex.Matches(places, pattern);

            List<string> destinations = new List<string>();
            int travelPoints = 0;

            foreach (Match match in matches)
            {
                string currDestination = match.Groups["destination"].ToString();
                destinations.Add(currDestination);
                travelPoints += currDestination.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
