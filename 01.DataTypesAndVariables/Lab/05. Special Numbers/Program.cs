using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                ushort sumOfDigits = 0;

                while (currentNum != 0)
                {
                    byte currentDigit = (byte)(currentNum % 10);
                    currentNum /= 10;
                    sumOfDigits += currentDigit;
                }

                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
