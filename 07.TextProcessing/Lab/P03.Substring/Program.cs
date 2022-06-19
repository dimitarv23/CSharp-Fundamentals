using System;

namespace P03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string banned = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(banned))
            {
                text = text.Replace(banned, "");
            }

            Console.WriteLine(text);
        }
    }
}
