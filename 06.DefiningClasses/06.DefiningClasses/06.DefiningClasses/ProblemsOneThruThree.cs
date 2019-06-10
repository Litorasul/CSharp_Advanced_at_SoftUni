using _06.DefiningClasses;
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < counter; i++)
            {               
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
