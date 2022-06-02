using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> drumsQuality = new List<int>(); //New list for current qualities
            List<double> initialPricesOfDrums = new List<double>(); //New list for prices

            //Set the starting qualities to default qualities
            for (int i = 0; i < drumSet.Count; i++)
            {
                drumsQuality.Add(drumSet[i]);
            }

            //Set the prices of each drum
            for (int i = 0; i < drumSet.Count; i++)
            {
                initialPricesOfDrums.Add(drumSet[i] * 3.0);
            }

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                //Lower each drum by the given hit power
                for (int i = 0; i < drumsQuality.Count; i++)
                {
                    drumsQuality[i] -= hitPower;

                    //If the drum broke down
                    if (drumsQuality[i] <= 0)
                    {
                        if (initialPricesOfDrums[i] > savings)
                        {
                            //If there's not enough money, we remove
                            //the drum and it's price from all the lists
                            drumsQuality.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            initialPricesOfDrums.RemoveAt(i);
                            //Iterate through the index again, because there's a new element on it now
                            i--;
                        }
                        else
                        {
                            //Buy a new drum and reset it to it's original quality
                            savings -= initialPricesOfDrums[i];
                            drumsQuality[i] = drumSet[i];
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drumsQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
