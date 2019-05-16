using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperations
{
    class BasicQueue
    {

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = input[0];
            int elementsToDequeue = input[1];
            int toPeek = input[2];

            int[] numbersPull = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> theQueue = new Queue<int>();
            int count = elementsToEnqueue > numbersPull.Length ? numbersPull.Length : elementsToEnqueue;

            for (int i = 0; i < count; i++)
            {
                theQueue.Enqueue(numbersPull[i]);
            }

            if (elementsToEnqueue > elementsToDequeue)
            {
                for (int i = 0; i < elementsToDequeue; i++)
                {
                    theQueue.Dequeue();
                }
            }
            else
            {
                theQueue.Clear();
            }

            if (theQueue.Contains(toPeek))
            {
                Console.WriteLine("true");
            }
            else if (theQueue.Count != 0)
            {
                Console.WriteLine(theQueue.Min());
            }
            else if (theQueue.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
