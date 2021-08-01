using System;
using System.Collections.Generic;

namespace NickHOOP
{
    class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Pizza", 3000, false, false),
            new Food("Wings", 3000, false, false),
            new Food("Eggs", 3000, false, false),
            new Food("Ice Cream", 3000, false, false),
            new Food("Cake", 3000, false, false),
            new Food("Hamburger", 3000, false, false),
            new Food("Sub", 3000, false, false)
        };
    }
     
    public Food Serve()
    {
        var random = new Random();
        int index = random.Next(Menu.Count);
        Console.WriteLine(Menu[index]);
        System.Console.WriteLine(Menu[index]);
        return Menu[index];
        
    }
}

}
