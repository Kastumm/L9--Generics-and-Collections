using System;
namespace LessonL9
{
    public static class AssignmentL9
    {
        public static void Main(string[] args)
        {
            string[] carsArray = new string[] { "Mercedes", "BMW", "Audi", "Volvo", "Mazda", "Toyota", "Jeep", "Honda" };
            List<string> cars = new List<string>(carsArray);

            Console.WriteLine("Get item by Index");
            string bestCar = cars[2]; //Get item by index
            Console.WriteLine($"{bestCar}\n");

            Console.WriteLine("Set item at given Index");
            cars[6] = "Ferrari"; //Set item at given index
            Console.WriteLine($"{cars[6]}\n");

            var temp = cars[1]; //Item Swap
            cars[1] = cars[5];
            cars[5] = temp;

            Console.WriteLine("Swap cars");
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[5]);
        }

        //Everything else in my project!
        //GenericRipositoryPattern implemented in my Project

    }

}