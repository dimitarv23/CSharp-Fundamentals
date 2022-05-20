using System;

namespace P05_Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int currNum = start; currNum <= end; currNum++)
            {
                Console.Write($"{(char)currNum} ");
            }
        }
    }
}
