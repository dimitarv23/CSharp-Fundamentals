using System;

namespace P01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal foodQuantity = decimal.Parse(Console.ReadLine());
            decimal hayQuantity = decimal.Parse(Console.ReadLine());
            decimal coverQuantity = decimal.Parse(Console.ReadLine());
            decimal guineaWeight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                foodQuantity -= 0.3m;

                if (i % 2 == 0)
                {
                    hayQuantity -= foodQuantity * 0.05m;
                }

                if (i % 3 == 0)
                {
                    coverQuantity -= guineaWeight / 3;
                }

                if (foodQuantity <= 0 || hayQuantity <= 0 || coverQuantity <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQuantity:f2}, Hay: {hayQuantity:f2}, Cover: {coverQuantity:f2}.");
        }
    }
}
