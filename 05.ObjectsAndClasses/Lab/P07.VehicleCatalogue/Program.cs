using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.VehicleCatalogue
{
    class Car
    {
        public Car(string brand, string model, int hp)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = hp;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] info = input.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                int additionalInfo = int.Parse(info[3]); //Horsepower if a car, weight if a truck

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, additionalInfo);
                    catalogue.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, additionalInfo);
                    catalogue.Trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            List<Car> sortedCars = catalogue.Cars.OrderBy(x => x.Brand).ToList();
            List<Truck> sortedTrucks = catalogue.Trucks.OrderBy(x => x.Brand).ToList();

            if (sortedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (sortedTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
