using System;

namespace P06_Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            bool isBalanced = true;
            int openingPerentheses = 0;
            int closingPerentheses = 0;

            for (byte i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingPerentheses++;
                    closingPerentheses = 0;

                    if (openingPerentheses > 1)
                    {
                        isBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    if (openingPerentheses == 0)
                    {
                        isBalanced = false;
                    }
                    closingPerentheses++;
                    openingPerentheses = 0;
                }
            }
            Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
        }
    }
}
