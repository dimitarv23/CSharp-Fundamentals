using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = 0;

            string input = Console.ReadLine();

            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    budget += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }

            double productPrice = 0;
            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    productPrice = 2;
                }
                else if (product == "Water")
                {
                    productPrice = 0.70;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.50;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.80;
                }
                else if (product == "Coke")
                {
                    productPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }

                if (budget >= productPrice)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    budget -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {budget:f2}");
        }
    }
}
