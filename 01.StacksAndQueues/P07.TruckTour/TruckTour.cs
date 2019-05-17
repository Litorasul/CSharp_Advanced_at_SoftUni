using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int[] petrolPump = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(petrolPump);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var pump in petrolPumps)
                {
                    
                    int petrol = pump[0];
                    int distance = pump[1];

                    totalFuel += petrol - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
