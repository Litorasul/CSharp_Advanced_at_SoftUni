using System;
using System.Collections.Generic;

namespace P04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int[] collection = new int[counter];
            HashSet<int> uniqueElements = new HashSet<int>();

            for (int i = 0; i < counter; i++)
            {
                int input = int.Parse(Console.ReadLine());
                collection[i] = input;
                uniqueElements.Add(input);
            }

            int evenTimesElement = 0;

            foreach (var uniqueItem in uniqueElements)
            {
                int count = 0;

                foreach (var item in collection)
                {
                    if (uniqueItem == item)
                    {
                        count++;
                    }
                }
                if (count % 2 == 0 && count != 0)
                {
                    evenTimesElement = uniqueItem;
                    break;
                }
            }

            Console.WriteLine(evenTimesElement);

        }
    }
}
