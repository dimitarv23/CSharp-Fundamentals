using System;

namespace P03_Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            decimal difference = (decimal)Math.Abs(firstNum - secondNum);
            const decimal eps = 0.000001m;
            bool areEqual = false;

            if (difference < eps)
            {
                areEqual = true;
            }
            Console.WriteLine(areEqual);
        }
    }
}
