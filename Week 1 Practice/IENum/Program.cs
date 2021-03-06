using System;
using System.Collections.Generic;

namespace IENum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            
                // Let's make a string array
            string[] wordArray = new string[]
            {
                "Goat", "Bear", "Skunk", "Deer"
            };
            // And a List of strings
            List<string> wordList = new List<string>()
            {
                "Plate", "Cup", "Fork", "Meat Cleaver", "Spatula"
            };
            // We can call our function with either!
            LoopingSomeWords(wordArray);
            LoopingSomeWords(wordList);


        }

            // That's because our function will accept ANY collection of strings
            static void LoopingSomeWords(IEnumerable<string> someWords)
            {
                foreach(var word in someWords)
                {
                    Console.WriteLine(word);
                }
            }
    }
}
