using System;

namespace NickHOOP
{
    class IronNinja
    {
        // public abstract void Consume(IConsumable item);
        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();

            SweetTooth mySweetTooth = new SweetTooth();
            Food chicken = new Food("Chicken", 1200, false, false);
            Food pizza = new Food("Pizza", 1200, false, false);
            mySweetTooth.Consume(chicken);
            mySweetTooth.Consume(pizza);
            System.Console.WriteLine(mySweetTooth.IsFull);
            System.Console.WriteLine(chicken.GetInfo());
            System.Console.WriteLine(pizza.GetInfo());
            
            System.Console.WriteLine("------------------------");

            SpiceHound mySpiceHound = new SpiceHound();
            Food taco = new Food("Taco", 2200, false, false);
            Food nachos = new Food("Nachos", 1200, false, false);
            System.Console.WriteLine(mySpiceHound.IsFull);
            System.Console.WriteLine(taco.GetInfo());
            System.Console.WriteLine(nachos.GetInfo());

            System.Console.WriteLine("------------------------");
            int sweetToothCal = chicken.Calories + pizza.Calories;
            int spiceHoundCal = taco.Calories + nachos.Calories;
            
            

            if ( sweetToothCal > spiceHoundCal )
            {
                System.Console.WriteLine($"Sweet tooth consumed more calories.");
            } else 
            {
                System.Console.WriteLine("Spice hound consumed more calories");
            }
        }
    }
}
