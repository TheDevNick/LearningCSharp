using System;
using System.Collections.Generic;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initializing a empty list for foods
            List<string> Menu = new List<string>();
            // using the add function to add to the list
            Menu.Add("Pizza");
            Menu.Add("Chicken");
            Menu.Add("Sandwich");
            Menu.Add("Wings");
            Menu.Add("Eggs");
            Menu.Add("Tacos");
            System.Console.WriteLine(Menu[2]);
            System.Console.WriteLine($"We have {Menu.Count} food items on the menu");

            // Looping through the Menu lists

            System.Console.WriteLine("-------Looping Through Menu list--------");

            for (int i = 0; i < Menu.Count; i++)
            {
                if (Menu[i] == "Eggs")
                {
                    Menu.RemoveAt(i); //removed egg from menu
                    Menu.Insert(i, "Egg Salad"); //replaced eggs with egg salad at the same index
                }
                Random rand = new Random();
                
                System.Console.WriteLine($"Food Item: {Menu[i]}");
            }

            List<int> myNumbers = new List<int>();
            myNumbers.Add(1);
            myNumbers.Add(2);
            myNumbers.Add(3);
            myNumbers.Add(4);
            myNumbers.Add(5);
            myNumbers.Add(6);

            for (int i = 0; i < myNumbers.Count; i++)
            {
                if (myNumbers[0] == 1)
                {
                    
                myNumbers.Insert(0, 0);
                }
                // System.Console.WriteLine(myNumbers[i]);
            }
        }

    }
}
