using System;

namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(GetSum(words[0], words[1]));
        }
        static long GetSum(string firstWord, string secondWord)
        {
            // firstWord:   secondWord:
            // Gosho        PetarPetrov
            // first loop iterates the indices: 0, 1, 2, 3, 4 -> the length of the smaller string
            // second loop iterates the indices: 5, 6, 7, 8, 9, 10 -> the characters from the bigger string that weren't iterated through the first loop

            long result = 0;

            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                result += firstWord[i] * secondWord[i];
            }
            for (int i = Math.Min(firstWord.Length, secondWord.Length); i < Math.Max(firstWord.Length, secondWord.Length); i++)
            {
                if (firstWord.Length > secondWord.Length)
                {
                    result += firstWord[i];
                    continue;
                }
                result += secondWord[i];
            }

            return result;
        }
    }
}
