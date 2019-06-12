using P06.SpeedRacing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double consumption = double.Parse(input[2]);

                Car car = new Car(model, fuel, consumption);
                cars.Add(car);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandInfo = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string modelDriven = commandInfo[1];
                int distance = int.Parse(commandInfo[2]);

                Car carDriven = cars.Where(c => c.Model == modelDriven)
                    .FirstOrDefault();

                carDriven.Drive(carDriven, distance);
            }

            foreach (var vihacle in cars)
            {
                Console.WriteLine($"{vihacle.Model} {vihacle.FuelAmmount:F2} {vihacle.TraveledDistance}");
            }
        }
    }
}
