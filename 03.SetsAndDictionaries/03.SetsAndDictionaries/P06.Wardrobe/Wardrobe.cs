using System;
using System.Collections.Generic;

namespace P06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe 
                = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (wardrobe.ContainsKey(color))
                    {
                        if (wardrobe[color].ContainsKey(clothes[j]))
                        {
                            wardrobe[color][clothes[j]]++;
                        }
                        else
                        {
                            wardrobe[color][clothes[j]] = 1;
                        }
                    }
                    else
                    {
                        wardrobe[color] = new Dictionary<string, int>();
                        wardrobe[color][clothes[j]] = 1;
                    }
                }

            }

            string[] itemToFind = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string colorToFind = itemToFind[0];
            string pieceToFind = itemToFind[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var dress in color.Value)
                {
                    if (color.Key == colorToFind && dress.Key == pieceToFind)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                }
            }
        }
    }
}
