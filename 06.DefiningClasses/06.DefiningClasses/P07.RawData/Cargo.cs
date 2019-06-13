using System;
using System.Collections.Generic;
using System.Text;

namespace P07.RawData
{
    public class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }

        public Cargo()
        {

        }

        public Cargo(int cargoWeight, string cargoType )
        {
            Weight = cargoWeight;
            Type = cargoType;
        }
    }
}
