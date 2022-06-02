using System;

namespace CarManufacturer
{
     public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            {
                car.Make = "VW";
                car.Model = "MK3";
                car.Year = 1992;
                car.FuelQuantity = 50;
                car.FuelConsumption = 0.7;
            }
             
            Console.WriteLine($"Make:{car.Make}; Model:{car.Model}; Year:{car.Year}.");
            double distance = 45;
            car.Drive(distance);
            Console.WriteLine(car.WhoAmI());

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car carOne = new Car();
            Car carTwo = new Car(make, model, year);
            Car carThree = new Car(make, model, year, fuelQuantity, fuelConsumption);





        }
    }
}
