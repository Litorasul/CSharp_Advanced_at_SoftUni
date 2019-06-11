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
            bool itIsPossible = IsFuelEnough(car, distance);
            double fuelNeeded = distance * car.FuelConsumption;

            if (itIsPossible)
            {

            }
            else
            {

            }
        }


        private bool IsFuelEnough(Car car, int distance)
        {
            bool result = false;
            double fuelNeeded = distance * car.FuelConsumption;

            if (car.FuelAmmount >= fuelNeeded)
            {
                result = true;
            }
            return result;
        }
    }
}
