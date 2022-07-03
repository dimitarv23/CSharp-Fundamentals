using System;

namespace P01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double price = 0;

            while (input != "regular" && input != "special")
            {
                double currPrice = double.Parse(input);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                price += currPrice;
                input = Console.ReadLine();
            }

            double priceWithTax = 1.2 * price;

            if (price == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {price:f2}$");
            Console.WriteLine($"Taxes: {priceWithTax - price:f2}$");
            Console.WriteLine("-----------");

            if (input == "special")
            {
                priceWithTax *= 0.9;
            }
            Console.WriteLine($"Total price: {priceWithTax:f2}$");
        }
    }
}
