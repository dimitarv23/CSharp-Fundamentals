﻿using System;

namespace P04_Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            
            int sumOfChars = 0;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sumOfChars += letter;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
