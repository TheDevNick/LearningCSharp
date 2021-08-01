using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];
            System.Console.WriteLine("Enter you fav movie");

            for (int i = 0; i < movies.Length; i++)
            {
            movies[i] = Console.ReadLine();
                
            }

            System.Console.WriteLine("here they are alphabetically:");
            Array.Sort(movies);
            for (int i = 0; i < movies.Length; i++)
            {
                System.Console.WriteLine(movies[i]);
            }


        }
    }
}
