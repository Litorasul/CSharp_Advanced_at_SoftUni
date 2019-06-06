using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 1; i <= capacity; i++)
            {
                numbers.Add(i);
            }

            int[] devisors = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var number in devisors)
            {
                numbers = numbers.Where(n => n % number == 0)
                    .ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
