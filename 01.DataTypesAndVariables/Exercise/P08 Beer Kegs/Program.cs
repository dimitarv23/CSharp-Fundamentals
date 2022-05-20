using System;

namespace P08_Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string biggestKegInfo = string.Empty;
            double maxKegVolume = 0;

            for (int i = 1; i <= n; i++)
            {
                string info = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * radius * radius * height;

                if (kegVolume > maxKegVolume)
                {
                    maxKegVolume = kegVolume;
                    biggestKegInfo = info;
                }
            }
            Console.WriteLine(biggestKegInfo);
        }
    }
}
