using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string faze = string.Empty;

            if (age >= 0 && age <= 2)
            {
                faze = "baby";
            }
            else if (age <= 13)
            {
                faze = "child";
            }
            else if (age <= 19)
            {
                faze = "teenager";
            }
            else if (age <= 65)
            {
                faze = "adult";
            }
            else if (age >= 66)
            {
                faze = "elder";
            }
            Console.WriteLine(faze);
        }
    }
}
