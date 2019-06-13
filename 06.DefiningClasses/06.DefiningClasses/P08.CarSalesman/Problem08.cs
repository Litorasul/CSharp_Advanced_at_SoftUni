using P08.CarSalesman;
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
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < count; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(engineInfo);
                engines.Add(engine);

            }

            count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(carInfo, engines);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }


        }

        private static Car CreateCar(string[] carInfo, List<Engine> engines)
        {
            Car car = new Car();
            if (carInfo.Length == 2)
            {
                car.Model = carInfo[0];
                car.Engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
            }
            else if (carInfo.Length == 3)
            {
                int intValue;
                bool isInt = int.TryParse(carInfo[2].ToString(), out intValue);
                if (isInt)
                {
                    car.Model = carInfo[0];
                    car.Engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                    car.Weight = carInfo[2];
                }
                else
                {
                    car.Model = carInfo[0];
                    car.Engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                    car.Colour = carInfo[2];
                }
            }
            else
            {
                car.Model = carInfo[0];
                car.Engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                car.Weight = carInfo[2];
                car.Colour = carInfo[3];
            }

            return car;
        }

        private static Engine CreateEngine(string[] engineInfo)
        {
            Engine eng = new Engine();
            if (engineInfo.Length == 2)
            {
                eng.Model = engineInfo[0];
                eng.Power = engineInfo[1];

            }
            else if (engineInfo.Length == 3)
            {
                int intValue;
                bool isInt = int.TryParse(engineInfo[2].ToString(), out intValue);
                if (isInt)
                {
                    eng.Model = engineInfo[0];
                    eng.Power = engineInfo[1];
                    eng.Displacement = engineInfo[2];
                }
                else
                {
                    eng.Model = engineInfo[0];
                    eng.Power = engineInfo[1];
                    eng.Efficiency = engineInfo[2];
                }
            }
            else
            {
                eng.Model = engineInfo[0];
                eng.Power = engineInfo[1];
                eng.Displacement = engineInfo[2];
                eng.Efficiency = engineInfo[3];
            }

            return eng;
        }
    }
}
