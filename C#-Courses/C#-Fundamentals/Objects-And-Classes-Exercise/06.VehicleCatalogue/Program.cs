using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    public class Car
    {
        public Car(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public void PrintCar(List<Car> cars)
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Horsepower: {HorsePower}");
        }

    }

    public class Truck
    {
        public Truck(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }

    public class Catalog
    {
        public List<Truck> Truck { get; set; } = new List<Truck>();
        public List<Car> Car { get; set; } = new List<Car>();


        public double GetAverageHorsePowerForCar()
        {
            double averageHorsePower = 0;
            foreach (var item in Car)
            {
                averageHorsePower += item.HorsePower;
            }

            double rezult = averageHorsePower / Car.Count;
            return rezult;
        }

        public double GetAverageHorsePowerForTruck()
        {
            double averageHorsePower = 0;
            foreach (var item in Truck)
            {
                averageHorsePower += item.HorsePower;
            }

            double rezult = averageHorsePower / Truck.Count;
            return rezult;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "truck")
                {
                    Truck currentTruck = new Truck(commandArgs[0], commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));
                    catalog.Truck.Add(currentTruck);

                }
                else
                {
                    Car currentCar = new Car(commandArgs[0], commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));
                    catalog.Car.Add(currentCar);
                }

                command = Console.ReadLine();
            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                foreach (var item in catalog.Car.OrderBy(c => c.Model))
                {
                    if (item.Model == model)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {item.Model}\nColor: {item.Color}\nHorsepower: {item.HorsePower}");

                    }

                }
                foreach (var item in catalog.Truck.OrderBy(t => t.Model))
                {
                    if (item.Model == model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {item.Model}\nColor: {item.Color}\nHorsepower: {item.HorsePower}");
                    }

                }

                model = Console.ReadLine();
            }

            Console.WriteLine($"Cars have average horsepower of: {catalog.GetAverageHorsePowerForCar():F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {catalog.GetAverageHorsePowerForTruck():F2}.");
        }
    }
}
