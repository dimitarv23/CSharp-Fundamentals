using System;

namespace P06MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleChars(input));
        }
        static string GetMiddleChars(string text)
        {
            if (text.Length % 2 == 0)
            {
                return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
            }
            else
            {
                return $"{text[text.Length / 2]}";
            }
        }
    }
}
