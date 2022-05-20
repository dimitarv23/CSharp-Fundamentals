using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
