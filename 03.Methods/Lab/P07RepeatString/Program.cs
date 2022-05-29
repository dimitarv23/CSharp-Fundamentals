using System;
using System.Text;

namespace P07RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(item, repeats));
        }
        static string RepeatString(string n, int r)
        {
            StringBuilder repeatedString = new StringBuilder();

            for (int i = 0; i < r; i++)
            {
                repeatedString.Append(n);
            }
            return repeatedString.ToString();
        }
    }
}
