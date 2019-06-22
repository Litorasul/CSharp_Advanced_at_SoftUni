using System;
using W01.CustomStructures;

namespace P07.CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> listy = new DoublyLinkedList<string>();

            listy.AddFirst("aaaaa");
            listy.AddFirst("bbbbb");
            listy.AddFirst("ccc");
            listy.AddFirst("dddd");
            listy.AddFirst("eeeee");

            foreach (var item in listy)
            {
                Console.WriteLine(item);
            }
        }
    }
}
