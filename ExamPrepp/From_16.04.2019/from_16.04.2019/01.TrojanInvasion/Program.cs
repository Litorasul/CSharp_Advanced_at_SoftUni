using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int trojanWavesCount = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> spartanDefences = new List<int>(input);
            Stack<int> trojanAttacks= new Stack<int>();

            for (int i = 1; i <= trojanWavesCount; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                AddWarriors(trojanAttacks, input);


                if (i % 3 == 0)
                {
                    int aditionalDefence = int.Parse(Console.ReadLine());
                    spartanDefences.Add(aditionalDefence);
                }

                while (trojanAttacks.Count > 0 && spartanDefences.Count > 0)
                {
                    int trojanWorrior = trojanAttacks.Pop();
                    int spartanShield = spartanDefences[0];

                    if (trojanWorrior > spartanShield)
                    {
                        trojanWorrior -= spartanShield;
                        trojanAttacks.Push(trojanWorrior);
                        spartanDefences.RemoveAt(0);
                    }
                    else if (trojanWorrior < spartanShield)
                    {
                        spartanShield -= trojanWorrior;
                        spartanDefences[0] = spartanShield;
                    }
                    else
                    {
                        spartanDefences.RemoveAt(0);
                    }
                }

                if (spartanDefences.Count == 0)
                {
                    break;
                }
            }

            if (spartanDefences.Count == 0)
            {
                TrojansWin(trojanAttacks);
            }
            else
            {
                SpartansWin(spartanDefences);
            }
        }

        private static void AddWarriors(Stack<int> trojanAttacks, int[] input)
        {
            foreach (var warrior in input)
            {
                trojanAttacks.Push(warrior);
            }
        }

        private static void TrojansWin(Stack<int> trojanAttacks)
        {
            Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
            Console.WriteLine($"Warriors left: {string.Join(", ", trojanAttacks)}");
        }

        private static void SpartansWin(List<int> spartanDefences)
        {
            Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", spartanDefences)}");
        }
    }
}
