using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string pattern = @"([#|])(?<food>[A-Za-z ]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(message, pattern);

            int totalCalories = matches.Sum(match => int.Parse(match.Groups["calories"].Value));
            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["food"]}, Best before: {match.Groups["expirationDate"]}, Nutrition: {match.Groups["calories"]}");
            }
        }
    }
}
