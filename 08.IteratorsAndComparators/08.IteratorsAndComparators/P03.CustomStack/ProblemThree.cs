using System;
using System.Linq;

namespace P03.CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            var theStack = new MyStack<int>();

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    if (command.Contains("Push"))
                    {
                        command = command.Remove(0, 5);
                        int[] elements = command
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse).ToArray();

                        foreach (var item in elements)
                        {
                            theStack.Push(item);
                        }
                    }
                    else if (command == "Pop")
                    {
                        theStack.Pop();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var item in theStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in theStack)
            {
                Console.WriteLine(item);
            }

        }
    }

}
