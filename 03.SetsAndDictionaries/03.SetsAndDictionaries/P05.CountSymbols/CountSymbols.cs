using System;
using System.Collections.Generic;

namespace P05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedSet<char> uniqueElements = new SortedSet<char>();

            foreach (var item in input)
            {
                uniqueElements.Add(item);
            }

            foreach (var uniqueItem in uniqueElements)
            {
                int count = 0;

                foreach (var item in input)
                {
                    if (uniqueItem == item)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{uniqueItem}: {count} time/s");
            }
        }
    }
}
