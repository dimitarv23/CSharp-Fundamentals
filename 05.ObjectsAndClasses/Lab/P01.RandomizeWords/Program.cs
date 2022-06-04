using System;

namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            RandomizeString(input);
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
        static void RandomizeString(string[] original)
        {
            Random rnd = new Random();

            for (int i = 0; i < original.Length; i++)
            {
                int randomIndex = rnd.Next(0, original.Length);

                string temp = original[i];
                original[i] = original[randomIndex];
                original[randomIndex] = temp;
            }
        }
    }
}
