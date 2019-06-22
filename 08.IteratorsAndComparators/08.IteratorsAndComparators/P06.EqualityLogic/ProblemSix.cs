using System;
using System.Collections.Generic;

namespace P06.EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<Person> hash = new HashSet<Person>();
            SortedSet<Person> sorted = new SortedSet<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);
                hash.Add(person);
                sorted.Add(person);
            }

            Console.WriteLine(hash.Count);
            Console.WriteLine(sorted.Count);
        }
    }
}
