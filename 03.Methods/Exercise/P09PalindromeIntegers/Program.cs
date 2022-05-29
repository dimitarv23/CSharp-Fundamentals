using System;

namespace P09PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input));
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
