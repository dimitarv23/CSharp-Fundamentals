using System;

namespace _07TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageOfPerson = int.Parse(Console.ReadLine());

            double price = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                    {
                        price = 12;
                    }
                    else if (ageOfPerson > 18 && ageOfPerson <= 64)
                    {
                        price = 18;
                    }
                    else if (ageOfPerson > 64 && ageOfPerson <= 122)
                    {
                        price = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;

                case "Weekend":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                    {
                        price = 15;
                    }
                    else if (ageOfPerson > 18 && ageOfPerson <= 64)
                    {
                        price = 20;
                    }
                    else if (ageOfPerson > 64 && ageOfPerson <= 122)
                    {
                        price = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;

                case "Holiday":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                    {
                        price = 5;
                    }
                    else if (ageOfPerson > 18 && ageOfPerson <= 64)
                    {
                        price = 12;
                    }
                    else if (ageOfPerson > 64 && ageOfPerson <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
            }
            Console.WriteLine($"{price}$");
        }
    }
}
