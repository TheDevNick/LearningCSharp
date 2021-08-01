using System;
using System.Collections.Generic;

namespace Inheritance
{
   abstract class Vehicle
{
    public int NumPassengers;
    public string Color;
    protected double Odometer;

    public abstract void MakeNoise();

    public string VehicleType;
    // Say Vechicle has two overloaded constructors
    // We will either need to pass up two values (int, string), from Car ...
    public Vehicle(int numPas, string col, string type = "Unknown Vehicle Type", double miles = 0)
    {   
        NumPassengers = numPas;
        Color = col;
        Odometer = miles;
        VehicleType = type;
    }

    // Or just one string value.  
    public Vehicle(string col, string type)
    {
        VehicleType = type;
        NumPassengers = 5;
        Color = col;
        Odometer = 0;
    }

    public virtual void GetInfo()
    {
        System.Console.WriteLine($"Vehicle Type: {VehicleType}");
        System.Console.WriteLine($"Color: {Color}");
        System.Console.WriteLine($"Miles: {Odometer}");
        System.Console.WriteLine($"Max Passengers: {NumPassengers}");
    }
    
}

    class Person 
    {
        public List<Vehicle> OwnedVehicles;

        public Person()
        {
            OwnedVehicles = new List<Vehicle>();

        }

        public void AddToVehicles(Vehicle newV)
        {
            OwnedVehicles.Add(newV);
        }

    }

}


// find the length 
// find the suare root of that length 