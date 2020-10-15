using System;
using System.Collections.Generic;

namespace InheritanceExercisesOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car volvo = new Car(1, "Volvo", "740", 4, "Car har started");

            Car audi = new Car(2, "audi", "a3", 4, "Car har started");

            Truck saab = new Truck(1, "saab", "saabtruck", 2000);
            
            Truck volvoTruck = new Truck(1, "volvo", "volvotruck", 4000);

            List<Vehicle> vehicle = new List<Vehicle>();

            vehicle.Add(volvo);
            vehicle.Add(audi);
            vehicle.Add(volvoTruck);

            foreach (var e in vehicle)
            {
                Console.WriteLine(e.Brand + " " + e.ModelName);
            }





        }
    }
}
