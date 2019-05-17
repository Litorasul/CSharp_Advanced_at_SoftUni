using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionBoutique
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>();
            int[] inputClothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            foreach (var item in inputClothes)
            {
                clothes.Push(item);
            }
            int racksUsed = 0;
            while (clothes.Count != 0)
            {
                int currentSum = 0;
                int currentItem = clothes.Peek();
                while (currentSum + currentItem <= rackCapacity)
                {
                    currentSum += currentItem;
                    clothes.Pop();
                    if (clothes.Count != 0)
                    {
                        currentItem = clothes.Peek();
                    }
                    else
                    {
                        break;
                    }
                    
                }
                racksUsed++;
            }

            Console.WriteLine(racksUsed);
        }
    }
}
