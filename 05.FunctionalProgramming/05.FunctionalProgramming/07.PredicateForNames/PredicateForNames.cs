using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLenght = int.Parse(Console.ReadLine());

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length <= maxLenght)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
