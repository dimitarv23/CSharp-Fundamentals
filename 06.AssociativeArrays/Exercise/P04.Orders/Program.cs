using System;
using System.Collections.Generic;

namespace P04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                double quantity = double.Parse(productInfo[2]);

                if (products.ContainsKey(productName))
                {
                    products[productName][0] = productPrice;
                    products[productName][1] += quantity;
                }
                else
                {
                    products.Add(productName, new List<double>() { productPrice, quantity });
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
