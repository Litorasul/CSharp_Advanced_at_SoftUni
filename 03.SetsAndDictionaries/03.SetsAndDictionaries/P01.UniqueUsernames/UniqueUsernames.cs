using System;
using System.Collections.Generic;

namespace P01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                set.Add(input);
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
