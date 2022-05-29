using System;

namespace P05MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(CheckExpression(num1, num2, num3));
        }
        static string CheckExpression(int n1, int n2, int n3)
        {
            string result1 = IsPositiveNegativeOrZero(n1);
            string result2 = IsPositiveNegativeOrZero(n2);
            string result3 = IsPositiveNegativeOrZero(n3);

            bool checkPositive = (result1 == "positive" && result2 == "positive" && result3 == "positive")
                || (result1 == "positive" && result2 == "negative" && result3 == "negative")
                || (result1 == "negative" && result2 == "positive" && result3 == "negative")
                || (result1 == "negative" && result2 == "negative" && result3 == "positive");
            bool checkZero = result1 == "zero" || result2 == "zero" || result3 == "zero";

            if (checkPositive)
            {
                return "positive";
            }
            else if (checkZero)
            {
                return "zero";
            }
            else
            {
                return "negative";
            }
        }
        static string IsPositiveNegativeOrZero(int n)
        {
            if (n < 0)
            {
                return "negative";
            }
            else if (n == 0)
            {
                return "zero";
            }
            else
            {
                return "positive";
            }
        }
    }
}
