using System;

namespace P10MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                int digit = n % 10;
                n /= 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                int digit = n % 10;
                n /= 10;

                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }
    }
}
