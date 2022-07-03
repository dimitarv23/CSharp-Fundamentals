using System;
using System.Text;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder reversed = new StringBuilder();
            for (int i = 1; i <= input.Length; i++)
            {
                reversed.Append(input[input.Length - i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
