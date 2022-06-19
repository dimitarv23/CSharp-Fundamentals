using System;
using System.Linq;
using System.Text;

namespace P01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] rv = input.ToCharArray().Reverse().ToArray();
                Console.WriteLine($"{input} = {string.Join("", rv)}");

                input = Console.ReadLine();
            }
        }
    }
}
