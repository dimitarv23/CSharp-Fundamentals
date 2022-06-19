using System;

namespace P02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            long sum = 0;

            foreach (char ch in text)
            {
                if (ch > firstChar && ch < secondChar)
                {
                    sum += ch;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
