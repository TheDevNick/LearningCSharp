using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Car : Vehicle, IRideable 
    {
        public string Make;
        public string Model;
        public double DistanceTraveled 
        {
            get {return Odometer;}
            set {Odometer = value;}
        }  
        public void Ride(double distance)
        {
            System.Console.WriteLine("I am driving!");
            DistanceTraveled += distance;
        } 

        public override void MakeNoise()
        {
            System.Console.WriteLine("BEEP BEEP!");
        }


        public Car(string color, string make, string model, string type) : base(color, type)
        {
            Make = make;
            Model = model;
        }


        public override void GetInfo()
    {
        base.GetInfo();
        System.Console.WriteLine($"Make: {Make}");
        System.Console.WriteLine($"Model: {Model}");
    }
    }
}