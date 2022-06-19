using System;
using System.Text;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            foreach (string input in inputs)
            {
                char letterBefore = input[0];
                char letterAfter = input[input.Length - 1];
                StringBuilder numberString = new StringBuilder();

                for (int i = 1; i < input.Length - 1; i++)
                {
                    numberString.Append(input[i]);
                }

                decimal number = decimal.Parse(numberString.ToString());

                if (char.IsUpper(letterBefore))
                {
                    number /= letterBefore - 64;
                }
                else
                {
                    number *= letterBefore - 96;
                }

                if (char.IsUpper(letterAfter))
                {
                    number -= letterAfter - 64;
                }
                else
                {
                    number += letterAfter - 96;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
