using System;
using System.Linq;

namespace P02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = m => Console.WriteLine($"Sir {m}");

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}
