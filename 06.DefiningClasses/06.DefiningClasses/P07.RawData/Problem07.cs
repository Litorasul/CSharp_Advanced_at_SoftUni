using P07.RawData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();

                if (input != string.Empty)
                {
                    Car car = new Car(input);
                    cars.Add(car);
                }
            }

            string command = Console.ReadLine();



            if (command == "fragile")
            {
                cars = cars.Where(c => Fragile(c))
                   .ToList();


            }
            else
            {
                cars = cars.Where(c => c.Cargo.Type == "flamable")
                    .Where(c => c.Engine.Power > 250)
                    .ToList();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }

        private static bool Fragile(Car c)
        {
            if (c.Cargo.Type == "fragile"
                && c.TireOne.Pressure < 1
                && c.TireTwo.Pressure < 1
                && c.TireThree.Pressure < 1
                && c.TireFour.Pressure < 1) 
            {
                return true;
            }
            return false;
        }
    }
}
