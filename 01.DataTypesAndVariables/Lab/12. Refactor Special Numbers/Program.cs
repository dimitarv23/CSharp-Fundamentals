using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                int currentNum = i;
                int sumOfDigits = 0;

                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }

                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
