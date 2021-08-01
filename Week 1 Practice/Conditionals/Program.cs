using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rand  = new Random();

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(rand.Next(1, 8));
            }

        }
    }
}
