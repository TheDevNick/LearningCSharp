using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = {1,2,3,4};
           string[] games = {"COD", "2k", "Apex", "Rainbow"};

           foreach (string game in games)
           {
               System.Console.WriteLine(game);
           }

           for (int i = 0; i < arr.Length ; i++)
           {
            //    System.Console.WriteLine(i);
           }
        }
    }
}
