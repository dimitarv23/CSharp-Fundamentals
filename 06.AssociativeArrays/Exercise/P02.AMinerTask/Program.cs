using System;
using System.Collections.Generic;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> resourcesAndQuantities = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resourcesAndQuantities.ContainsKey(resource))
                {
                    resourcesAndQuantities[resource] += quantity;
                }
                else
                {
                    resourcesAndQuantities.Add(resource, quantity);
                }

                resource = Console.ReadLine();
            }

            foreach (var item in resourcesAndQuantities)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
