using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<string> theList = new List<string>();
            

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                theList.Add(input);
            }

            GenericSwap<string>(theList);
        }

        public static void GenericSwap<T>(List<T> list)
        {
            int[] swap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int indexOne = swap[0];
            int indexTwo = swap[1];

            T temp = list[indexOne];
            list[indexOne] = list[indexTwo];
            list[indexTwo] = temp;

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }

        }
    }
}
