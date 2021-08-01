using System;
using System.Collections.Generic;

namespace NickHEssentials
{
    class Puzzles
    {

        static void Main(string[] args)
        {
            int[] numArray = new int[10];
            System.Console.WriteLine("------Random Array:");
            RandomArray(numArray);  
            System.Console.WriteLine("------Coin Toss:");
            TossCoin();  
            System.Console.WriteLine("------Names:");
            Names("");        
        }


        public static int[] RandomArray(int[] arr)
        {
             int min = arr[0];
             int max = arr[0];
             int sum = 0;


            Random randNum = new Random();


            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(5, 25);
                // Console.WriteLine(arr[i]);

                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];

            }
                Console.WriteLine($"Max: {max}");
                Console.WriteLine($"Min: {min}");
                Console.WriteLine($"Sum: {sum}");
            return arr;

        }

       public static int randomSide(int val1, int val2)
        {
            Random rand = new Random();
            return rand.Next(val1,val2);
        }

        static string TossCoin()
        {
            string[] arr = {"Heads", "Tails"};
            string answer = arr[Puzzles.randomSide(0,2)];
            Console.WriteLine(answer);
            return answer;
        }

        public static string Names(string name)
        {
            var myNames = new List<string>{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();


            for (int i = 0; i < myNames.Count; i++)
            {
            int idx = rand.Next(myNames.Count);
                // Console.WriteLine(myNames[idx]);
                if(myNames[idx].Length > 4)
                {
                    
                Console.WriteLine(myNames[idx]);
                }
            }


            return name;
        }
    }
}
