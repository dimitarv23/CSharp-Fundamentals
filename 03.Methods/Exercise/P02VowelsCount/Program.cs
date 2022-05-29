using System;

namespace P02VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetVowelsCount(input));
        }
        static int GetVowelsCount(string input)
        {
            int vowelsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (IsVowel(input[i].ToString()))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
        static bool IsVowel(string c)
        {
            if (c.ToLower() == "a" || c.ToLower() == "e" || c.ToLower() == "i" || c.ToLower() == "o" || c.ToLower() == "u")
            {
                return true;
            }
            return false;
        }
    }
}
