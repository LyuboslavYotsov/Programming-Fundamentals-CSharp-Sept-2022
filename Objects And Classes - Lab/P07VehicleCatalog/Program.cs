using System;
using System.Collections.Generic;
using System.Linq;

namespace P07VehicleCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Catalogue> catalogueList = new List<Catalogue>();
            List<Car> carList = new List<Car>();
            List<Truck> truckList = new List<Truck>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input
                    .Split("/");

                string type = inputArr[0];
                string brand = inputArr[1];
                string model = inputArr[2];
                int value = int.Parse(inputArr[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, value);
                    carList.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, value);
                    truckList.Add(newTruck);
                }
                Catalogue newCatalog = new Catalogue(carList, truckList);
            }
            if (carList.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in carList.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (truckList.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in truckList.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Catalogue
    {
        public Catalogue(List<Car> car, List<Truck> truck)
        {
            Car = car;
            Truck = truck;
        }

        public List<Car> Car { get; set; }

        public List<Truck> Truck { get; set; }
    }
}
