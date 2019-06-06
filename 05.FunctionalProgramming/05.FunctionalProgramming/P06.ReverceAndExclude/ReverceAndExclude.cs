using System;
using System.Linq;

namespace P06.ReverceAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int devisor = int.Parse(Console.ReadLine());

            collection = collection.Where(n => n % devisor != 0)
                .ToArray();

            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
