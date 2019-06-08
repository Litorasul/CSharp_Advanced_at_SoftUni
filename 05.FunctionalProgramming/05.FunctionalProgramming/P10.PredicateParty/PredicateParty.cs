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

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] commArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string toDo = commArr[0].ToLower();
                string action = commArr[1].ToLower();

                if (toDo == "remove")
                {
                    if (action == "lenght")
                    {
                        int lenght = int.Parse(commArr[2]);

                        partyGuests = partyGuests
                            .Where(p => p.Count() <= lenght)
                            .ToList();

                    }
                    else if (action == "startswith")
                    {
                        string beginning = commArr[2];
                    }
                    else if (action == "endswith")
                    {
                        string end = commArr[2];

                    }
                }
                else
                {
                    if (action == "lenght")
                    {
                        int lenght = int.Parse(commArr[2]);

                    }
                    else if (action == "startswith")
                    {
                        string beginning = commArr[2];
                    }
                    else if (action == "endswith")
                    {
                        string end = commArr[2];

                    }

                }


            }
        }
    }
}
