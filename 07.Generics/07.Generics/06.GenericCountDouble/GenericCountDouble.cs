using Generics;
using System;

namespace _06.GenericCountDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < count; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.List.Add(input);
            }
            double inp = double.Parse(Console.ReadLine());
            box.GreaterThan(inp);

            Console.WriteLine(box.GreaterElements.Count);
        }
    }
}
