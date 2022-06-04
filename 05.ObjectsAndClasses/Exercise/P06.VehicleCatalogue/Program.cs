using System;
using System.Collections.Generic;

namespace P06.VehicleCatalogue
{
    class Car
    {
        public Car(string model, string color, int horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
    class Truck
    {
        public Truck(string model, string color, int horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string catalogue = Console.ReadLine();

            while (catalogue != "End")
            {
                string[] vehicleInfo = catalogue
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsepower = int.Parse(vehicleInfo[3]);

                if (type == "car")
                {
                    Car newCar = new Car(model, color, horsepower);
                    cars.Add(newCar);
                }
                else if (type == "truck")
                {
                    Truck newTruck = new Truck(model, color, horsepower);
                    trucks.Add(newTruck);
                }

                catalogue = Console.ReadLine();
            }

            string searchCatalogue = Console.ReadLine();

            while (searchCatalogue != "Close the Catalogue")
            {
                if (cars.Exists(car => car.Model == searchCatalogue))
                {
                    int indexOfCar = cars.FindIndex(car => car.Model == searchCatalogue);
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {cars[indexOfCar].Model}");
                    Console.WriteLine($"Color: {cars[indexOfCar].Color}");
                    Console.WriteLine($"Horsepower: {cars[indexOfCar].Horsepower}");
                }
                if (trucks.Exists(truck => truck.Model == searchCatalogue))
                {
                    int indexOfTruck = trucks.FindIndex(truck => truck.Model == searchCatalogue);
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {trucks[indexOfTruck].Model}");
                    Console.WriteLine($"Color: {trucks[indexOfTruck].Color}");
                    Console.WriteLine($"Horsepower: {trucks[indexOfTruck].Horsepower}");
                }

                searchCatalogue = Console.ReadLine();
            }

            int totalCarsHorsepower = 0;
            int totalTrucksHorsepower = 0;

            foreach (Car car in cars)
            {
                totalCarsHorsepower += car.Horsepower;
            }
            foreach (Truck truck in trucks)
            {
                totalTrucksHorsepower += truck.Horsepower;
            }

            double averageHorsepowerCars = 0;
            double averageHorsepowerTrucks = 0;

            if (cars.Count > 0)
            {
                averageHorsepowerCars = (double)totalCarsHorsepower / cars.Count;
            }
            if (trucks.Count > 0)
            {
                averageHorsepowerTrucks = (double)totalTrucksHorsepower / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowerTrucks:f2}.");
        }
    }
}
