using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSize = sizes[0];
            int secondSize = sizes[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            AddInSet(firstSet, firstSize);
            AddInSet(secondSet, secondSize);

            HashSet<int> result = new HashSet<int>();

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    result.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void AddInSet(HashSet<int> set, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int input = int.Parse(Console.ReadLine());
                set.Add(input);
            }
        }
    }
}
