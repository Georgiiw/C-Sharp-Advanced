using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
     class Car
     {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double consumption = distance * this.FuelConsumption;
            if (consumption <= this.FuelQuantity)
                this.FuelQuantity -= consumption;
            else
                Console.WriteLine("Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            string info = $"Make:{this.Make} Model:{this.Model}" +
                $" Year:{this.Year} Fuel:{this.FuelQuantity:f2} ";
            return info;
        }


        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 0.8;

        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;

        }
    }
}
