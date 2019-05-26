using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
