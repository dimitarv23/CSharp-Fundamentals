using System;

namespace P01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            int energyLeft = initialEnergy;
            int battlesWon = 0;
            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                int currEnergy = int.Parse(input);

                if (energyLeft >= currEnergy)
                {
                    energyLeft -= currEnergy;
                    battlesWon++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energyLeft} energy");
                    break;
                }

                if (battlesWon % 3 == 0)
                {
                    energyLeft += battlesWon;
                }

                input = Console.ReadLine();
            }

            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energyLeft}");
            }
        }
    }
}
