using System;

namespace W01.CustomStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList();

            linkedList.AddFirst(1);
            linkedList.AddFirst(0);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            //linkedList.Print(Console.WriteLine);
            //Console.WriteLine(linkedList.Count == 4);

            //linkedList.RemoveFirst();
            //linkedList.Print(Console.WriteLine);
            //Console.WriteLine(linkedList.Count == 3);

            //linkedList.RemoveLast();
            //linkedList.Print(Console.WriteLine);
            //Console.WriteLine(linkedList.Count == 2);


            Console.WriteLine(linkedList.Contains(2));
            Console.WriteLine(linkedList.Contains(9));
        }
    }
}
