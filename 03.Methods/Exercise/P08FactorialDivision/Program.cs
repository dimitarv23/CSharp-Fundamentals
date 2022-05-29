using System;

namespace P08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{GetFactorial(firstNum) / GetFactorial(secondNum):f2}");
        }
        static decimal GetFactorial(int number)
        {
            decimal result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
