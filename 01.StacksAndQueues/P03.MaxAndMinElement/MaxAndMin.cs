using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MaxAndMinElement
{
    class MaxAndMin
    {
        static void Main(string[] args)
        {
            Stack<int> theStack = new Stack<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int[] commandArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int command = commandArray[0];

                if (command == 1)
                {
                    //Push element
                    int element = commandArray[1];
                    theStack.Push(element);
                }
                else if (command == 2)
                {
                    // Delete the top element
                    if (theStack.Count != 0)
                    {
                        theStack.Pop();
                    }
                }
                else if (command == 3)
                {
                    //Print the Max
                    if (theStack.Count != 0)
                    {
                        Console.WriteLine(theStack.Max());
                    }
                  
                }
                else
                {
                    //Print the Min
                    if (theStack.Count != 0)
                    {
                        Console.WriteLine(theStack.Min());
                    }
                  
                }
            }

            Console.WriteLine(string.Join(", ", theStack));
        }
    }
}
