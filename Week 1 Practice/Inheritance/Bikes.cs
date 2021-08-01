using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Bike : Vehicle
    {
        public int Speed;
        public Bike(int numPass, string color, string type, int speed ) : base(numPass, color, type)
        {
            Speed = speed;
        }

        public override void MakeNoise()
        {
            System.Console.WriteLine("Skrrrt skrrrt!");
        }

     public override void GetInfo()
    {
        base.GetInfo();
        System.Console.WriteLine($"Speed: {Speed}");
    }
    }
}