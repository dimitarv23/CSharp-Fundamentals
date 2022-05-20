using System;

namespace P04_Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= range; currentNumber++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor < currentNumber; divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{currentNumber} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
