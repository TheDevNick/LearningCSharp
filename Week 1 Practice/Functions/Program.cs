using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string greeting = sayHello();
            System.Console.WriteLine(greeting);
        }

        public static string sayHello(string name = "Nick") 
        {
            return $"Hello {name}!";
        }
    }
}
