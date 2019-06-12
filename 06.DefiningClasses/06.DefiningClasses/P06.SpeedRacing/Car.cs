using System;
using System.Collections.Generic;
using System.Text;

namespace P06.SpeedRacing
{
    public class Car
    {
        private double traveledDistance;

        public string Model { get; set; }

        public double FuelAmmount { get; set; }

        public double FuelConsumption { get; set; }

        public double TraveledDistance
        {
            get => this.traveledDistance;
        }

        public Car()
        {
            traveledDistance = 0;
        }

        public Car(string model, double fuel, double consumption)
            : this()
        {
            Model = model;
            FuelAmmount = fuel;
            FuelConsumption = consumption;
        }

        public void Drive(Car car, int distance)
        {           
            double fuelNeeded = distance * car.FuelConsumption;
            bool itIsPossible = IsFuelEnough(car, fuelNeeded);

            if (itIsPossible)
            {
                car.FuelAmmount -= fuelNeeded;
                traveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }


        private bool IsFuelEnough(Car car, double fuelNeeded)
        {
            bool result = false;

            if (car.FuelAmmount >= fuelNeeded)
            {
                result = true;
            }
            return result;
        }
    }
}
