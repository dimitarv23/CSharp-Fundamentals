using System;
using System.Numerics;

namespace P02_From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                string twoNumbers = Console.ReadLine();
                string[] numbers = twoNumbers.Split(' ');

                BigInteger leftNumber = BigInteger.Parse(numbers[0]);
                BigInteger rightNumber = BigInteger.Parse(numbers[1]);

                BigInteger biggerNumber = leftNumber > rightNumber ? leftNumber : rightNumber;
                int sumOfDigits = 0;

                while (biggerNumber != 0)
                {
                    sbyte currDigit = (sbyte)(biggerNumber % 10);
                    biggerNumber /= 10;
                    sumOfDigits += currDigit;
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }

        }
    }
}
