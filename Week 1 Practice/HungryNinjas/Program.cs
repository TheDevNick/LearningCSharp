using System;

namespace NickHOOP
{
    class HungryNinjas
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Food foodItem1 = new Food("Pizza", 550, false, false);
            System.Console.WriteLine(foodItem1.Name);

            Buffet buffet = new Buffet(); 
            Food food = buffet.Serve();

            Ninja nick = new Ninja();
            nick.Serve();
            nick.Serve();
            nick.Serve();
            nick.Serve();
            nick.Serve();
            System.Console.WriteLine(nick.IsFull);
        }
    }
}
