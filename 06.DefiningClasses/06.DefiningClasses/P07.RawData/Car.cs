using System;
using System.Collections.Generic;
using System.Text;

namespace P07.RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire TireOne { get; set; }
        public Tire TireTwo { get; set; }
        public Tire TireThree { get; set; }
        public Tire TireFour { get; set; }

        public Car()
        {

        }
        //"{model[0]} {engineSpeed[1]} {enginePower[2]} {cargoWeight[3]} {cargoType[4]} 
        //{tire1Pressure[5]} {tire1Age[6]} {tire2Pressure[7]} {tire2Age[8]} 
        //{tire3Pressure[9]} {tire3Age[10]} {tire4Pressure[11]} {tire4Age[12]}"
        public Car(string carInfo)
        {
            string[] carArr = carInfo
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Model = carArr[0];

            Engine = new Engine(int.Parse(carArr[1]), int.Parse(carArr[2]));
            Cargo = new Cargo(int.Parse(carArr[3]), carArr[4]);
            TireOne = new Tire(double.Parse(carArr[5]), int.Parse(carArr[6]));
            TireTwo = new Tire(double.Parse(carArr[7]), int.Parse(carArr[8]));
            TireThree = new Tire(double.Parse(carArr[9]), int.Parse(carArr[10]));
            TireFour = new Tire(double.Parse(carArr[11]), int.Parse(carArr[12]));

        }

        public override string ToString()
        {
            return Model;
        }

    }
}
