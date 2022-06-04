using System;
using System.Collections.Generic;

namespace P03.SpeedRacing
{
    class Car
    {
        public Car(string model, double fuel, double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelConsumptionPerKm = fuelPerKm;
            this.TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public int TravelledDistance { get; set; }

        public bool IsFuelEnough(double distance)
        {
            double kmForFuel = FuelAmount / FuelConsumptionPerKm;
            return distance <= kmForFuel;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                Car newCar = new Car(carModel, fuelAmount, fuelConsumption);
                cars.Add(newCar);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] driveInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carToDrive = driveInfo[1];
                int distance = int.Parse(driveInfo[2]);

                int indexOfCar = cars.FindIndex(x => x.Model == carToDrive);

                if (cars[indexOfCar].IsFuelEnough(distance))
                {
                    cars[indexOfCar].FuelAmount -= distance * cars[indexOfCar].FuelConsumptionPerKm;
                    cars[indexOfCar].TravelledDistance += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
