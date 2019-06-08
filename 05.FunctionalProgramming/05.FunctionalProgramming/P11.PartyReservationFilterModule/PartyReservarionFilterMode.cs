using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();

            string filter = string.Empty;

            List<string> filters = new List<string>();

            while ((filter = Console.ReadLine()) != "Print")
            {
                string[] filterInfo = filter
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = filterInfo[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (action == "Remove filter")
                {
                    filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                }
            }

            Func<string, int, bool> lenghtFilter = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWithFilter = (name, param) => name.EndsWith(param);
            Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);

            foreach (var act in filters)
            {
                string[] actInfo = act.Split(";");

                string action = actInfo[0];
                string param = actInfo[1];

                if (action == "Starts with")
                {
                    names = names.Where(name => !startsWithFilter(name, param))
                        .ToArray();
                }
                else if (action == "Ends with")
                {
                    names = names.Where(name => !endsWithFilter(name, param))
                        .ToArray();
                }
                else if (action == "Contains")
                {
                    names = names.Where(name => !containsFilter(name, param))
                        .ToArray();
                }
                else if (action == "Lenght")
                {
                    int lenght = int.Parse(param);
                    names = names.Where(name => !lenghtFilter(name, lenght))
                        .ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
