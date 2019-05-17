using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.AutoRepairService
{
    class AutoRepairService
    {
        static void Main(string[] args)
        {
            Queue<string> carsToFix = new Queue<string>();
            Stack<string> carsFixed = new Stack<string>();
            string[] carsInput = Console.ReadLine()
                .Split()
                .ToArray();
            foreach (var car in carsInput)
            {
                carsToFix.Enqueue(car);
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Service")
                {
                    if (carsToFix.Count != 0)
                    {
                        carsFixed.Push(carsToFix.Dequeue());
                        Console.WriteLine($"Vehicle {carsFixed.Peek()} got served.");
                    }
                    
                }
                else if (command == "History")
                {
                    if (carsFixed.Count != 0)
                    {
                        Console.WriteLine(string.Join(", ", carsFixed));
                    }
                }
                else
                {
                    string[] commandArr = command.Split("-").ToArray();
                    string vehicle = commandArr[1];

                    if (carsFixed.Contains(vehicle))
                    {
                        Console.WriteLine("Served.");
                    }
                    else if (carsToFix.Contains(vehicle))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
            }
            if (carsToFix.Count != 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsToFix)}");
            }
            if (carsFixed.Count != 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", carsFixed)}");
            }
        }
    }
}
