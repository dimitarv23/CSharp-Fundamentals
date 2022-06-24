using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
            double totalIncome = 0;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double currIncome = price * quantity;
                    totalIncome += currIncome;
                    
                    Console.WriteLine($"{name}: {product} - {currIncome:f2}");
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
