using System;
using System.Linq;

namespace P08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] even = input.Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            int[] odd = input.Where(n => n % 2 != 0)
                .OrderBy(n => n)
                .ToArray();

            int[] result = new int[input.Length];
            int counter = 0;

            foreach (var number in even)
            {
                result[counter] = number;
                counter++;
            }

            foreach (var number in odd)
            {
                result[counter] = number;
                counter++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
