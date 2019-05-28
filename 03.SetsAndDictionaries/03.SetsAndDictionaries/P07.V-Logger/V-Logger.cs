using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggerCollection = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vlogger = commandArr[0];
                string action = commandArr[1];

                if (action == "joined" && !vloggerCollection.ContainsKey(vlogger))
                {
                    vloggerCollection[vlogger] = new Dictionary<string, SortedSet<string>>();
                    vloggerCollection[vlogger].Add("follows", new SortedSet<string>());
                    vloggerCollection[vlogger].Add("isFollowedBy", new SortedSet<string>());

                }
                else if (action == "followed")
                {
                    string followed = commandArr[2];
                    if (vlogger != followed 
                        && vloggerCollection.ContainsKey(followed)
                        && vloggerCollection.ContainsKey(vlogger))
                    {
                        vloggerCollection[vlogger]["follows"].Add(followed);
                        vloggerCollection[followed]["isFollowedBy"].Add(vlogger);
                    }

                }
            }

            int vloggerCount = vloggerCollection.Count;
            Console.WriteLine($"The V-Logger has a total of {vloggerCount} vloggers in its logs.");
            int counter = 1;

            foreach (var user in vloggerCollection
                .OrderByDescending(x => x.Value["isFollowedBy"].Count).ThenBy(y => y.Value["follows"].Count))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1. {user.Key} : {user.Value["isFollowedBy"].Count} followers, {user.Value["follows"].Count} following");
                    foreach (var item in user.Value["isFollowedBy"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                else
                {
                    Console.WriteLine($"{counter}. {user.Key} : {user.Value["isFollowedBy"].Count} followers, {user.Value["follows"].Count} following");
                }

                counter++;
            }

        }
    }


}
