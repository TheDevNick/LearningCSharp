using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> Users = new Dictionary<string, string>();
            Users.Add("Name", "Nick");  //key-value pair
            Users.Add("Major", "Software Engineering");
            Users.Add("Location", "Texas");

            System.Console.WriteLine("--------Users Information--------");
            System.Console.WriteLine($"Name: {Users["Name"]}");// getting Users name
            System.Console.WriteLine($"Major: {Users["Major"]}");
            System.Console.WriteLine($"Location: {Users["Location"]}");
            // looping through each key/value pair
            foreach (var User in Users)
            {
                System.Console.WriteLine($"User Key: {User.Key}");
                System.Console.WriteLine($"User Value: {User.Value}");
            }

            Dictionary<string, int> Awards = new Dictionary<string, int>();

            Awards.Add("Degrees", 2);
            Awards.Add("Certifications", 3);
            System.Console.WriteLine("--------Users Awards--------");
            System.Console.WriteLine($"Degrees: {Awards["Degrees"]}");
            System.Console.WriteLine($"Certifications: {Awards["Certifications"]}");


        }
    }
}
