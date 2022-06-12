using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string obtainedLegendary = string.Empty;
            bool flag = false;

            while (true)
            {
                string[] materialsAndQuantities = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string material = string.Empty;
                int quantity = 0;

                for (int i = 1; i < materialsAndQuantities.Length; i += 2)
                {
                    material = materialsAndQuantities[i];
                    quantity = int.Parse(materialsAndQuantities[i - 1]);

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (inventory.ContainsKey(material))
                        {
                            inventory[material] += quantity;
                        }
                        else
                        {
                            inventory.Add(material, quantity);
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }

                    if (inventory.ContainsKey("shards"))
                    {
                        if (inventory["shards"] >= 250)
                        {
                            obtainedLegendary = "Shadowmourne";
                            inventory["shards"] -= 250;
                            flag = true;
                            break;
                        }
                    }
                    if (inventory.ContainsKey("fragments"))
                    {
                        if (inventory["fragments"] >= 250)
                        {
                            obtainedLegendary = "Valanyr";
                            inventory["fragments"] -= 250;
                            flag = true;
                            break;
                        }
                    }
                    if (inventory.ContainsKey("motes"))
                    {
                        if (inventory["motes"] >= 250)
                        {
                            obtainedLegendary = "Dragonwrath";
                            inventory["motes"] -= 250;
                            flag = true;
                            break;
                        }
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            Console.WriteLine($"{obtainedLegendary} obtained!");

            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
