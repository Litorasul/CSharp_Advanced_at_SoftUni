using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.GenericSwapInt
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            List<int> theList = new List<int>();


            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                theList.Add(input);
            }

            GenericSwap(theList);

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
