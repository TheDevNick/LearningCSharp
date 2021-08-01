using System;
using System.Collections.Generic;

namespace NickHOOP
{
    class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
     public override bool IsFull
    {
        get 
        {
            if (this.calorieIntake >= 1200)
            {
                System.Console.WriteLine("Spice hound is full and can't eat anymore");
                return true;
            } else {return false;}
            
        }
    }
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
                if (!IsFull)
        {
            this.calorieIntake += item.Calories;
            // Random rand = new Random();
            ConsumptionHistory.Add(item);
            item.GetInfo();
        } else 
        {
            System.Console.WriteLine("Cannot eat anymore.");
        }
    }
}

}