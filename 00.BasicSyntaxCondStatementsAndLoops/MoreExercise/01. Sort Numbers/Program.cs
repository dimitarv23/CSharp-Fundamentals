using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int bigger = 0;

            if (num1 < num2)
            {
                bigger = num2;
                num2 = num1;
                num1 = bigger;
            }
            if (num2 < num3)
            {
                bigger = num3;
                num3 = num2;
                num2 = bigger;
            }
            if (num1 < num2)
            {
                bigger = num2;
                num2 = num1;
                num1 = bigger;
            }
            Console.WriteLine($"{num1}\n{num2}\n{num3}");
        }
    }
}
