using System;

namespace P09GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(a, b));
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                Console.WriteLine(GetMax(a, b));
            }
        }
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char GetMax(char a, char b)
        {
            return (char)Math.Max(a, b);
        }
        static string GetMax(string a, string b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
