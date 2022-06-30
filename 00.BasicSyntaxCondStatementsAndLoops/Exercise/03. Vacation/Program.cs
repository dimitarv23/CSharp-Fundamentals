using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfStay = Console.ReadLine();

            double price = 0;

            if (dayOfStay == "Friday")
            {
                if (groupType == "Students")
                {
                    price = 8.45;
                }
                else if (groupType == "Business")
                {
                    price = 10.90;
                }
                else if (groupType == "Regular")
                {
                    price = 15;
                }
            }
            else if (dayOfStay == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = 9.80;
                }
                else if (groupType == "Business")
                {
                    price = 15.60;
                }
                else if (groupType == "Regular")
                {
                    price = 20;
                }
            }
            else if (dayOfStay == "Sunday")
            {
                if (groupType == "Students")
                {
                    price = 10.46;
                }
                else if (groupType == "Business")
                {
                    price = 16;
                }
                else if (groupType == "Regular")
                {
                    price = 22.50;
                }
            }

            if (groupType == "Students" && numberOfPeople >= 30)
            {
                price *= 0.85;
            }
            if (groupType == "Business" && numberOfPeople >= 100)
            {
                numberOfPeople -= 10;
            }
            if (groupType == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                price *= 0.95;
            }
            price *= numberOfPeople;

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
