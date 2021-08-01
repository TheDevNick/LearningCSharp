using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car v = new Car("red", "Ford", "Escape", "Car");
            v.MakeNoise();
            Bike newBike = new Bike(1, "Black", "Bike", 10);
            newBike.MakeNoise();
            // Console.WriteLine("Hello World!");
            // Vehicle Kia = new Vehicle(5, "Purple", "Car", 109585);
            // Vehicle Ford = new Vehicle(4, "Red", "Car");
            // Vehicle Audi = new Vehicle(4, "Green", "Car");
            // Kia.GetInfo();

            
            // Car newCar = new Car("Blue", "Kia", "Optima", "car" );
            // System.Console.WriteLine($"{newCar.Make}");
            // newCar.GetInfo();

            // Bike newBike = new Bike(2, "Green", "Bike", 10);
            // System.Console.WriteLine();
            // newBike.GetInfo();

            // List<Vehicle> vehicles = new List<Vehicle>();
            // vehicles.Add(Kia);
            // vehicles.Add(Ford);
            // vehicles.Add(Audi);

            // vehicles.Add(newCar);

            // vehicles.Add(newBike);

            // foreach (var v in vehicles)
            // {
            //     System.Console.WriteLine("Getting Info.....");
            //     v.GetInfo();
            // }
        }
    }
}