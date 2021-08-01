using System;

namespace NickHOOP
{
class Food
{
    public string Name;
    public int Calories;
    // Foods can be Spicy and/or Sweet
    public bool IsSpicy; 
    public bool IsSweet; 
    // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

    public Food(string foorName, int foodCalories, bool isFoodSpicy, bool isFoodSweet)
    {
        this.Name = foorName;
        this.Calories = foodCalories;
        this.IsSpicy = isFoodSpicy;
        this.IsSweet = isFoodSweet;
    }
}

}
