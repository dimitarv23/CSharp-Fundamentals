using System;

namespace P10_Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            int currentPokePower = pokePower;
            int targetsPoked = 0;

            while (currentPokePower >= distance)
            {
                currentPokePower -= distance;
                targetsPoked++;

                if (currentPokePower == (double)pokePower / 2 && exhaustionFactor > 1)
                {
                    currentPokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
