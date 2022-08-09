using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(\@)[#]+[A-Z](?<productInfo>[A-Za-z0-9]{4,})[A-Z]\1[#]+";
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string productInfo = match.Groups["productInfo"].Value;
                    string digits = GetDigits(productInfo);

                    Console.WriteLine($"Product group: {(digits.Length == 0 ? "00" : digits)}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        static string GetDigits(string text)
        {
            StringBuilder digits = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
            }

            return digits.ToString();
        }
    }
}
