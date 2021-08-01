using System;

namespace ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            System.Console.WriteLine("Enter you students name");

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }

            Array.Sort(students);

            System.Console.WriteLine("Sorting Names......");

            for (int i = 0; i < students.Length; i++)
            {
                System.Console.WriteLine(students[i]);
            }

        }
    }
}
