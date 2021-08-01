using System;
using System.Collections.Generic;


namespace NickHOOP
{
    class Ninja : Buffet
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            if (calorieIntake > 1200)
            {
            return true;
            } else {return false;}
        }
    }
     
    // add a constructor
    public Ninja(int calIntake = 0)
    {
        this.calorieIntake = calIntake;
        FoodHistory = new List<Food>();
    }
     
     
    // build out the Eat method
    public void Eat(Food item)
    {
        if (IsFull == false)
        {
           var calValue = calorieIntake;
            var random = new Random();
            int index = random.Next(Menu.Count);
            FoodHistory.Add(Menu[index]);
            System.Console.WriteLine($"Food Name: {item}");
        } else {System.Console.WriteLine("The Ninja Is Full and can't eat nomore");}

    }
}

}
