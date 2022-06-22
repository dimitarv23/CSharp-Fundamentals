using System;
using System.Text.RegularExpressions;

namespace P01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+[' '][A-Z][a-z]+";

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
