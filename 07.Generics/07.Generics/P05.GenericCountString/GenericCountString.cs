using Generics;
using System;

namespace P05.GenericCountString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                box.List.Add(input);
            }
            string inp = Console.ReadLine();
            box.GreaterThan(inp);

            Console.WriteLine(box.GreaterElements.Count);
        }
    }
}
