using System;
using System.Text;

namespace P03CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            Console.WriteLine(GetCharsInRange(c1, c2));
        }
        static string GetCharsInRange(char start, char end)
        {
            if (end < start)
            {
                char rotation = end;
                end = start;
                start = rotation;
            }
            StringBuilder elements = new StringBuilder();

            for (char current = (char)(start + 1); current < end; current++)
            {
                elements.Append($"{current} ");
            }
            return elements.ToString();
        }
    }
}
