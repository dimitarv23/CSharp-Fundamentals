using System;

namespace P02_Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            ushort sumOfDigits = 0;

            while (number != 0)
            {
                byte currentDigit = (byte)(number % 10);
                number /= 10;
                sumOfDigits += currentDigit;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
