using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double currentPrice = 0;
            double totalPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int numberOfCapsules = int.Parse(Console.ReadLine());

                currentPrice = (days * numberOfCapsules) * pricePerCapsule;
                totalPrice += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
