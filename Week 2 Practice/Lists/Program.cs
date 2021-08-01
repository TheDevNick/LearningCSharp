using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();//initialized a empty list
            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                System.Console.WriteLine(shoppingList[i]);
            }

            System.Console.WriteLine("----------------------");

            shoppingList.Remove("Dreams"); //since Dreams is removed, Miracles start at index 0
            shoppingList.RemoveAt(1); //rainbow will get removed
            for (int i = 0; i < shoppingList.Count; i++)
            {
                System.Console.WriteLine(shoppingList[i]);
            }
        }
    }
}
