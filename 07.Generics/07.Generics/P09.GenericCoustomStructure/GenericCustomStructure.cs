using System;
using W01.CustomStructures;

namespace P09.GenericCoustomStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> doublyLinked= new DoublyLinkedList<string>();


            doublyLinked.AddFirst("first");
            doublyLinked.AddFirst("second");
            doublyLinked.AddLast("third");
            doublyLinked.AddLast("fourth");
            doublyLinked.AddLast("fifth");
            doublyLinked.AddFirst("last for good measure");

           //doublyLinked.Print(Console.WriteLine);

            doublyLinked.RemoveFirst();
            doublyLinked.RemoveLast();

             //doublyLinked.Print(Console.WriteLine);

            Console.WriteLine(doublyLinked.Contains("third"));
            Console.WriteLine(doublyLinked.Contains("check"));

            string[] array = doublyLinked.ToArray();

            foreach (var item in array)
            {
                Console.WriteLine($"{item} - from array");
            }

        }
    }
}
