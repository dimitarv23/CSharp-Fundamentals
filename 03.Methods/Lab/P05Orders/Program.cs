using System;

namespace P05Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculatePrice(product, quantity):f2}");
        }
        static double CalculatePrice(string product, int quantity)
        {
            if (product == "coffee")
            {
                return quantity * 1.50;
            }
            else if (product == "water")
            {
                return quantity;
            }
            else if (product == "coke")
            {
                return quantity * 1.40;
            }
            else if (product == "snacks")
            {
                return quantity * 2;
            }
            return 0;
        }
    }
}
