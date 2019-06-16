using System;

namespace Generics
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

            Console.WriteLine(box.ToString());
        }
    }
}
