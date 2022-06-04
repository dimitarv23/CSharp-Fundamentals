using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.RawData
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }
    class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
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
                string model = carInfo[0];
                int speed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Engine newEngine = new Engine(speed, enginePower);
                Cargo newCargo = new Cargo(cargoWeight, cargoType);
                Car newCar = new Car(model, newEngine, newCargo);
                cars.Add(newCar);
            }

            List<Car> filteredCars = new List<Car>();
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                //If the wanted cargo type is fragile => get the cargos which are fragile and which weight is less than 1000kg
                filteredCars = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000)
                    .ToList();
            }
            else if (command == "flamable")
            {
                //If the wanted cargo type is flamable => get the cargos which are flamable and which power is greater than 250hp
                filteredCars = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .ToList();
            }

            foreach(Car car in filteredCars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}
