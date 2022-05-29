using System;

namespace P01SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetSign(int.Parse(Console.ReadLine()));
        }
        static void GetSign(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }
    }
}
