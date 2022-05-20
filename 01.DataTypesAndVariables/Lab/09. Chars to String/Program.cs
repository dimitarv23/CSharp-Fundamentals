using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            char thirdCh = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstCh}{secondCh}{thirdCh}");
        }
    }
}
