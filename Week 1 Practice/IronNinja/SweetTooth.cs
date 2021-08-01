using System;
using System.Collections.Generic;

namespace NickHOOP
{
class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull
    {
        get 
        {
            if (this.calorieIntake >= 1500)
            {
                System.Console.WriteLine("Sweet tooth Is Full and can't eat anymore");
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
