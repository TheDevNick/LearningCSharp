using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Horse : IRideable
    {
        public string Name;
        public double Endurance;
        public void Ride(double distance)
        {
            System.Console.WriteLine("Nehhyy I'm riding");
            if (distance >= Endurance)
            {
                distance = Endurance;
            }
            DistanceTraveled += distance;
        } 
        public double DistanceTraveled {get;set;}  

        public Horse(string name, double endurance)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.DistanceTraveled = 0;
        }
    }
}