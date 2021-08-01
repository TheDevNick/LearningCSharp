using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Vehicle Car1 = new Vehicle(5, 99.0);
            System.Console.WriteLine($"The {Car1.Color} car can hold {Car1.MaxNumPassengers} with a max speed of {Car1.MaxSpeed} MPH");
            Car1.MakeNoise(); //Using the MakeNoise method that don't take any parameters
            Car1.Color = "red";
            System.Console.WriteLine(Car1.ColorProp);
        }
    }
}
