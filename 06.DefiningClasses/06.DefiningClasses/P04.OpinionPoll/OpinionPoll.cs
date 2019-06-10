using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<Person> peoples = new List<Person>();

            for (int i = 0; i < counter; i++)
            {
                string[] personsInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = personsInput[0];
                int personAge = int.Parse(personsInput[1]);

                Person person = new Person(personName, personAge);

                peoples.Add(person);
            }

            var result = peoples.Where(p => p.Age > 30)
                .ToList();

            foreach (var pers in result.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{pers.Name} - {pers.Age}");
            }
        }
    }
}
