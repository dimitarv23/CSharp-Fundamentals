using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.NeedForSpeed3
{
    class Car
    {
        public Car(string brand, int mileage, int fuel)
        {
            this.Brand = brand;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public string Brand { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string brand = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                if (!cars.Any(x => x.Brand == brand))
                {
                    cars.Add(new Car(brand, mileage, fuel));
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Drive")
                {
                    string car = cmdArgs[1];
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);

                    Drive(cars, car, distance, fuel);
                }
                else if (action == "Refuel")
                {
                    string car = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);

                    Refuel(cars, car, fuel);
                }
                else if (action == "Revert")
                {
                    string car = cmdArgs[1];
                    int decreaseKm = int.Parse(cmdArgs[2]);

                    Revert(cars, car, decreaseKm);
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Brand} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        static void Drive(List<Car> cars, string brand, int distance, int fuel)
        {
            int indexOfCurrCar = cars.FindIndex(x => x.Brand == brand);

            if (cars[indexOfCurrCar].Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }

            cars[indexOfCurrCar].Mileage += distance;
            cars[indexOfCurrCar].Fuel -= fuel;
            Console.WriteLine($"{brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (cars[indexOfCurrCar].Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {cars[indexOfCurrCar].Brand}!");
                cars.RemoveAt(indexOfCurrCar);
            }
        }

        static void Refuel(List<Car> cars, string brand, int fuel)
        {
            int indexOfCurrCar = cars.FindIndex(x => x.Brand == brand);

            if (cars[indexOfCurrCar].Fuel + fuel >= 75)
            {
                fuel = 75 - cars[indexOfCurrCar].Fuel;
                cars[indexOfCurrCar].Fuel = 75;
            }
            else
            {
                cars[indexOfCurrCar].Fuel += fuel;
            }

            Console.WriteLine($"{brand} refueled with {fuel} liters");
        }

        static void Revert(List<Car> cars, string brand, int decreaseKm)
        {
            int indexOfCurrCar = cars.FindIndex(x => x.Brand == brand);

            cars[indexOfCurrCar].Mileage -= decreaseKm;

            if (cars[indexOfCurrCar].Mileage <= 10000)
            {
                cars[indexOfCurrCar].Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{brand} mileage decreased by {decreaseKm} kilometers");
            }
        }
    }
}
