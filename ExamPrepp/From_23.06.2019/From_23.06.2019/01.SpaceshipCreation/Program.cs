using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SpaceshipCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>();
            Stack<int> physical = new Stack<int>();
            var items = new Dictionary<string, int>();
            items.Add("Glass", 0);
            items.Add("Aluminium", 0);
            items.Add("Lithium", 0);
            items.Add("Carbon fiber", 0);



            int[] liquidsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] physicalInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            foreach (var liquid in liquidsInfo)
            {
                liquids.Enqueue(liquid);
            }

            foreach (var physic in physicalInfo)
            {
                physical.Push(physic);
            }

            int count = 0;
            if (liquids.Count > 0 && physical.Count > 0)
            {
                count = liquids.Count;
            }

            for (int i = 0; i < count; i++)
            {
                int liquid = liquids.Dequeue();
                int physic = physical.Pop();

                if (liquid + physic == 25)
                {
                    items["Glass"]++;
                    continue;
                }
                else if (liquid + physic == 50)
                {
                    items["Aluminium"]++;
                    continue;
                }
                else if (liquid + physic == 75)
                {
                    items["Lithium"]++;
                    continue;
                }
                else if (liquid + physic == 100)
                {
                    items["Carbon fiber"]++;
                    continue;
                }

                physical.Push(physic + 3);

            }

            bool allItemsCreated = true;
            foreach (var item in items)
            {
                if (item.Value < 1)
                {
                    allItemsCreated = false;
                    break;
                }
            }

            if (allItemsCreated)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine
                    ("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (physical.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physical)}");
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Aluminium: {items["Aluminium"]}");
            sb.AppendLine($"Carbon fiber: {items["Carbon fiber"]}");
            sb.AppendLine($"Glass: {items["Glass"]}");
            sb.AppendLine($"Lithium: {items["Lithium"]}");

            Console.WriteLine(sb.ToString().Trim());

        }
    }
}
