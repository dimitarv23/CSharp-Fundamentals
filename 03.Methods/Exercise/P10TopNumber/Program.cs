using System;

namespace P10TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsSumDivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsSumDivisibleBy8(int n)
        {
            int sumOfDigits = 0;

            while (n != 0)
            {
                sumOfDigits += n % 10;
                n /= 10;
            }
            return sumOfDigits % 8 == 0;
        }
        static bool HasOddDigit(int n)
        {
            while (n != 0)
            {
                byte digit = (byte)(n % 10);
                n /= 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
