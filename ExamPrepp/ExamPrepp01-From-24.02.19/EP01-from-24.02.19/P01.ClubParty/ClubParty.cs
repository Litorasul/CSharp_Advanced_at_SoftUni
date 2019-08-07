using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ClubParty
{
    class ClubParty
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());

            var hallsReservations = new Dictionary<string, List<int>>();

            string[] input = Console.ReadLine()
                .Split();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                bool isNumber = int.TryParse(input[i], out int reservation);
                if (isNumber)
                {
                    if (hallsReservations.Count == 0)
                    {
                        continue;
                    }
                    for (int j = 0; j < hallsReservations.Count; j++)
                    {
                        var item = hallsReservations.ElementAt(j);
                        var hallKey = item.Key;
                        var hallValue = item.Value;
                        bool isOverflowing = hallValue.Sum() + reservation > hallCapacity;
                        if (isOverflowing)
                        {
                            Console.WriteLine($"{hallKey} -> { string.Join(", ", hallValue)}");
                            hallsReservations.Remove(hallKey);                          
                        }
                        else
                        {
                            hallValue.Add(reservation);                                                       
                        }
                    }
                    
                }
                else
                {
                    hallsReservations[input[i]] = new List<int>(hallCapacity);
                }
            }

        }
    }
}
