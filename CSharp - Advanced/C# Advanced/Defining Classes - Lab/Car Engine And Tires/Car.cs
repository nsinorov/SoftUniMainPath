﻿using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()

        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelConsumption, fuelQuantity)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Make { get { return make; } set { make = value; } }

        public string Model { get { return model; } set { model = value; } }

        public int Year { get { return year; } set { year = value; } }

        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }

        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

        public void Drive(double distance)
        {
            double neededFuel = distance * fuelConsumption;

            if (neededFuel < fuelQuantity)
            {
                fuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"Fuel: {this.FuelQuantity:F2}");

            return result.ToString().Trim();
        }
    }
}