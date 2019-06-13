using System;
using System.Collections.Generic;
using System.Text;

namespace P08.CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {
            Displacement = "n/a";
            Efficiency = "n/a";
        }

    }
}
