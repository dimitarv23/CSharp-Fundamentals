using System;
using System.Linq;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = (char)(text[i] + 3);
            }

            text = string.Join("", characters);
            Console.WriteLine(text);
        }
    }
}
