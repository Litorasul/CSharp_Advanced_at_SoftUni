using System;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.List.Add(input);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
