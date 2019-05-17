using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    class FastFood
    {
        static void Main(string[] args)
        {
            Queue<int> orders = new Queue<int>();
            int allFood = int.Parse(Console.ReadLine());
            int[] ordersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var order in ordersInput)
            {
                orders.Enqueue(order);
            }

            Console.WriteLine(orders.Max());

            int currentOrder = orders.Peek();
            while (allFood - currentOrder >= 0)
            {
                allFood -= currentOrder;
                orders.Dequeue();
                if (orders.Count != 0)
                {
                    currentOrder = orders.Peek();
                }
                else
                {
                    break;
                }
                
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
