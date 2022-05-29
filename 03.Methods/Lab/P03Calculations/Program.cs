using System;

namespace P03Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Calculate(command, firstNum, secondNum);
        }
        static void Calculate(string command, int a, int b)
        {
            if (command == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (command == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else if (command == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
