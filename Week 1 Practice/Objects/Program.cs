using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Vehicle myVehicle = new Vehicle();
            System.Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people in it.");
            Classroom myClassroom = new Classroom(32);
            System.Console.WriteLine($"My classroom has {myClassroom.NumOfStudents} students in it.");
            Ace aceCompany = new Ace(150);
            System.Console.WriteLine($"ACE have {aceCompany.NumEmployees} employees and {aceCompany.NumDepartments} departments.");
        }
    }

    public class Vehicle
    {
        //Accessibility of class members is defaulted to private
        //so we must add the public keyword to anything we
        //want to allow outside access to.
        
        // this unassigned integer will default to 0
        public int NumPassengers;

        public Vehicle()
        {
            NumPassengers = 5;
        }
    }

    public class Classroom
    {
        public int NumOfStudents;

        public Classroom(int students)
        {
            NumOfStudents = students;
        }
    }

    public class Ace
    {
        public  int NumEmployees;
        public int NumDepartments;

        public Ace(int employee)
        {
            this.NumEmployees = employee;
            this.NumDepartments = 10;
        }
    }

}
