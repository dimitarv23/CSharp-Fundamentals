using System;

namespace P01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plunderDays = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalGained = 0;

            for (int i = 1; i <= plunderDays; i++)
            {
                totalGained += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalGained += 0.5 * dailyPlunder;
                }

                if (i % 5 == 0)
                {
                    totalGained *= 0.7;
                }
            }

            if (totalGained >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalGained:f2} plunder gained.");
            }
            else
            {
                double percentGained = (totalGained / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentGained:f2}% of the plunder.");
            }
        }
    }
}
