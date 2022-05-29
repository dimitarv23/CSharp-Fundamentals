using System;

namespace P08MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(@base, power));
        }
        static double MathPower(double x, double n)
        {
            double result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
