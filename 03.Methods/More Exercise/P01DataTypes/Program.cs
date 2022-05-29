using System;

namespace P01DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                EditInput(int.Parse(Console.ReadLine()));
            }
            else if (input == "real")
            {
                EditInput(double.Parse(Console.ReadLine()));
            }
            else if (input == "string")
            {
                EditInput(Console.ReadLine());
            }
        }
        static void EditInput(int n)
        {
            Console.WriteLine(2 * n);
        }
        static void EditInput(string n)
        {
            Console.WriteLine($"${n}$");
        }
        static void EditInput(double n)
        {
            Console.WriteLine($"{1.5 * n:f2}");
        }
    }
}
