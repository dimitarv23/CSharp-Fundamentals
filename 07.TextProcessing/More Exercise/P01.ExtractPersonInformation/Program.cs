using System;

namespace P01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int indexOfAt = text.IndexOf("@");
                int indexOfLine = text.IndexOf("|");
                string name = text.Substring(indexOfAt + 1, indexOfLine - indexOfAt - 1);

                int indexOfDS = text.IndexOf("#");
                int indexOfAsterisk = text.IndexOf("*");
                string age = text.Substring(indexOfDS + 1, indexOfAsterisk - indexOfDS - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
