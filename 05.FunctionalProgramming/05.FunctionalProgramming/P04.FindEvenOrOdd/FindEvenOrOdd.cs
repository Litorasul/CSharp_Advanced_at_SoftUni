using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FindEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = input[0];
            int finish = input[1];

            string filter = Console.ReadLine()
                .ToLower();


            List<int> numbers = new List<int>();

            for (int i = start; i <= finish; i++)
            {
                numbers.Add(i);
            }

            if (filter == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)
                    .ToList()));
                    
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)
                    .ToList()));
            }


        }

    }
}
