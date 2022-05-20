using System;

namespace P07_Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            short capacityLeft = 255;

            for (int i = 1; i <= n; i++)
            {
                short liters = short.Parse(Console.ReadLine());

                if (liters <= capacityLeft)
                {
                    capacityLeft -= liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(255 - capacityLeft);
        }
    }
}
