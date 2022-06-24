using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> boughtFurniture = new List<string>();
            decimal moneySpent = 0;
            string pattern = @">>(?<type>[A-Za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string[] furnitureInfo = input
                        .Split(new string[] { ">>", "<<", "!" }, StringSplitOptions.RemoveEmptyEntries);
                    string furnitureType = match.Groups["type"].Value;
                    decimal furniturePrice = decimal.Parse(match.Groups["price"].Value);
                    int furnitureQuantity = int.Parse(match.Groups["quantity"].Value);

                    boughtFurniture.Add(furnitureType);
                    moneySpent += furniturePrice * furnitureQuantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture: ");

            if (boughtFurniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, boughtFurniture));
            }

            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }
    }
}
