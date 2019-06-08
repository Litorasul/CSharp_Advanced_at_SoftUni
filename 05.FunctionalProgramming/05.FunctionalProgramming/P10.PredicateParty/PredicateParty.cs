using System;
using System.Linq;

namespace P10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var partyGuests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;

            Func<string, int, bool> lenghtFilter = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWithFilter = (name, param) => name.EndsWith(param);

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] commArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string toDo = commArr[0];
                string action = commArr[1];
                string parameter = commArr[2];

                if (toDo == "Remove")
                {
                    if (action == "StartsWith")
                    {
                        partyGuests = partyGuests.Where(name => !startsWithFilter(name, parameter))
                        .ToList();
                    }
                    else if (action == "EndsWith")
                    {
                        partyGuests = partyGuests.Where(name => !endsWithFilter(name, parameter))
                        .ToList();
                    }
                    else if (action == "Length")
                    {
                        int lenght = int.Parse(parameter);

                        partyGuests = partyGuests.Where(name => !lenghtFilter(name, lenght))
                        .ToList();

                    }
                }
                else
                {
                    if (action == "StartsWith")
                    {
                        var toDouble = partyGuests
                            .Where(name => startsWithFilter(name, parameter))
                            .ToList();

                        foreach (var item in toDouble)
                        {
                            partyGuests.Add(item);
                        }
                    }
                    else if (action == "EndsWith")
                    {
                        var toDouble = partyGuests.Where(name => endsWithFilter(name, parameter))
                        .ToList();

                        foreach (var item in toDouble)
                        {
                            partyGuests.Add(item);
                        }
                    }
                    else if (action == "Length")
                    {
                        int lenght = int.Parse(parameter);

                        var toDouble = partyGuests.Where(name => lenghtFilter(name, lenght))
                        .ToList();

                        foreach (var item in toDouble)
                        {
                            partyGuests.Add(item);
                        }

                    }
                }
            }

            if (partyGuests.Count() == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", partyGuests)} are going to the party!");
            }
        }
    }
}
