using System;
using System.Collections.Generic;

namespace P05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Person> people = new List<Person>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                var person = new Person(name, age, town);
                people.Add(person);

            }

            int n = int.Parse(Console.ReadLine());

            int countOfMatches = 1;
            int countOfMisses = 0;

            Person target = people[n - 1];

            foreach (var guy in people)
            {

                if (guy == target)
                {
                    continue;
                }

                if (guy.CompareTo(target) == 0)
                {
                    countOfMatches ++;
                }
                else
                {
                    countOfMisses++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfMisses} {people.Count}");
            }
        }
    }
}
