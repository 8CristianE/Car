using System;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car NewCar = new Car();

            NewCar.Make = "Ford";
            Console.WriteLine($"I just got a new car made by {NewCar.Make}");

            NewCar.Model = "Mustang";
            Console.WriteLine($"It's a {NewCar.Make} {NewCar.Model}");

            NewCar.Year = 2018;
            Console.WriteLine($"It's a year {NewCar.Year}");

        }
    }
}

