using System;

namespace P06CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateArea(sideA, sideB));
        }
        static double CalculateArea(double a, double b)
        {
            return a * b;
        }
    }
}
