using System;

namespace Vehicles
{
    class Vehicle
    {
         public int MaxNumPassengers;
         public string Color;
         public double MaxSpeed;

         public Vehicle(int maxPassengers, double maxSpeed, string color = "Blue")
         {
             this.MaxNumPassengers = maxPassengers;
             this.Color = color;
             this.MaxSpeed = maxSpeed;
         }

         public void MakeNoise(string noise)
         {
             System.Console.WriteLine(noise);
         }

         public void MakeNoise()
         {
             System.Console.WriteLine("BEEP");
         }

         public string ColorProp
         {
             get
             {
                 return $"This thing is {Color}";
             }

             set
             {
                 if(Color != "Green")
                 Color = value;
             }
         }
    }
}
