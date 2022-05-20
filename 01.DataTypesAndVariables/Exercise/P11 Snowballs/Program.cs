using System;
using System.Numerics;

namespace P11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger bestSnowballValue = BigInteger.Zero;
            short bestSnowballSnow = 0;
            short bestSnowballTime = 0;
            byte bestSnowballQuality = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
