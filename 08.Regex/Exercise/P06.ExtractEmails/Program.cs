using System;
using System.Text.RegularExpressions;

namespace P06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string emailPattern = @"(?<user>[a-z0-9\.\-_]+[a-z0-9]+)@(?<host>[a-z]+-*[a-z]+\.[a-z]+-*[a-z]+(\.[a-z]+-*[a-z]+)*)";

            MatchCollection matches = Regex.Matches(text, emailPattern);

            foreach (Match email in matches)
            {
                if (Char.IsLetterOrDigit(email.Value[0]))
                {
                    Console.WriteLine(email.Value);
                }
            }
        }
    }
}
