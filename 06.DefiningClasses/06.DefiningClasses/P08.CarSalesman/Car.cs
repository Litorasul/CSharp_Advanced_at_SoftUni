using System;
using System.Collections.Generic;
using System.Text;

namespace P08.CarSalesman
{
    class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public string Weight { get; set; }

        public string Colour { get; set; }

        public Car()
        {
            Weight = "n/a";
            Colour = "n/a";
        }

        public override string ToString()
        {
            string toReturn = $"{Model}:{Environment.NewLine}  {Engine.Model}:{Environment.NewLine}    Power: {Engine.Power}{Environment.NewLine}    Displacement: {Engine.Displacement}{Environment.NewLine}    Efficiency: {Engine.Efficiency}{Environment.NewLine}  Weight: {Weight}{Environment.NewLine}  Color: {Colour}";
            return toReturn;
        }
    }
}
