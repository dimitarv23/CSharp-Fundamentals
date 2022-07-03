using System;

namespace _02._English_Name_of_the_Last_Digit
{
    internal class Program
    {
        enum DigitName
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number %= 10;

            Console.WriteLine((DigitName)number);
        }
    }
}
