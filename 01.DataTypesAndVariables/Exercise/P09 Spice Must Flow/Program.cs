using System;
using System.Numerics;

namespace P09_Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            BigInteger totalYield = BigInteger.Zero;
            int days = 0;

            while (startingYield >= 100)
            {
                totalYield += (startingYield - 26);
                startingYield -= 10;
                days++;
            }

            if (totalYield < 26)
            {
                totalYield = 0;
            }
            else
            {
                totalYield -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
