namespace P06VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> vehicles = new List<Catalogue>();
            InsertVehicleInformation(vehicles);

            ShowVehiclesInfo(vehicles);

            CalculateAverageHorsePower(vehicles);
        }

        private static void CalculateAverageHorsePower(List<Catalogue> vehicles)
        {
            int carsHp = 0;
            int carCount = 0;
            int truckHp = 0;
            int truckCount = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "Car")
                {
                    carsHp += vehicle.HorsePower;
                    carCount++;
                }
                else if (vehicle.Type == "Truck")
                {
                    truckHp += vehicle.HorsePower;
                    truckCount++;
                }
            }
            if (carCount > 0)
            {
                double carsAverage = carsHp / (double)carCount;
                Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (truckCount > 0)
            {
                double truckAverage = truckHp / (double)truckCount;
                Console.WriteLine($"Trucks have average horsepower of: {truckAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }

        private static void ShowVehiclesInfo(List<Catalogue> vehicles)
        {
            string input;
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = input;
                Catalogue currVehicle = vehicles
                    .Where(x => x.Model == model)
                    .First();
                Console.WriteLine(currVehicle.ToString());
            }
        }

        private static void InsertVehicleInformation(List<Catalogue> vehicles)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = commArgs[0];
                if (type == "car")
                {
                    type = "Car";
                }
                if (type == "truck")
                {
                    type = "Truck";
                }
                string model = commArgs[1];
                string color = commArgs[2];
                int horsepower = int.Parse(commArgs[3]);
                Catalogue currentVehicle = new Catalogue(type, model, color, horsepower);
                vehicles.Add(currentVehicle);
            }
        }
    }

    public class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsePower)
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

        public override string ToString()
        {
            return $"Type: {this.Type}{Environment.NewLine}" +
                $"Model: {this.Model}{Environment.NewLine}" +
                $"Color: {this.Color}{Environment.NewLine}" +
                $"Horsepower: {this.HorsePower}";

        }
    }
}
