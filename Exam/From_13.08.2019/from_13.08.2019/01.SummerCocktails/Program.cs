using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> ingredients = new Queue<int>();

            foreach (var ingr in input)
            {
                ingredients.Enqueue(ingr);
            }


            input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> freshness = new Stack<int>();
            foreach (var fresh in input)
            {
                freshness.Push(fresh);
            }
            

            Dictionary<string, int> cocktails = new Dictionary<string, int>();



            while (ingredients.Count > 0 && freshness.Count > 0)
            {

                int currentIngredient = ingredients.Dequeue();
                int currentFreshness = freshness.Pop();
                if (currentIngredient == 0)
                {
                    if (ingredients.TryDequeue(out currentIngredient))
                    {
                        
                    }
                    else
                    {
                        break;
                    }
                }
                int mix = currentIngredient * currentFreshness;

                switch (mix)
                {
                    case 150:
                        {
                            if (cocktails.ContainsKey("Mimosa"))
                            {
                                cocktails["Mimosa"]++;
                            }
                            else
                            {
                                cocktails["Mimosa"] = 1;
                            }
                        }
                        break;
                    case 250:
                        {
                            if (cocktails.ContainsKey("Daiquiri"))
                            {
                                cocktails["Daiquiri"]++;
                            }
                            else
                            {
                                cocktails["Daiquiri"] = 1;
                            }
                        }
                        break;
                    case 300:
                        {
                            if (cocktails.ContainsKey("Sunshine"))
                            {
                                cocktails["Sunshine"]++;
                            }
                            else
                            {
                                cocktails["Sunshine"] = 1;
                            }
                        }
                        break;
                    case 400:
                        {
                            if (cocktails.ContainsKey("Mojito"))
                            {
                                cocktails["Mojito"]++;
                            }
                            else
                            {
                                cocktails["Mojito"] = 1;
                            }
                        }
                        break;
                    default:
                        {
                            currentIngredient += 5;
                            ingredients.Enqueue(currentIngredient);
                        }
                        break;
                }
            }

            if (cocktails.Count == 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
                PrintCocktails(cocktails);
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
                if (ingredients.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                PrintCocktails(cocktails);
            }
        }

        private static void PrintCocktails(Dictionary<string, int> cocktails)
        {
            foreach (var drink in cocktails.OrderBy(c => c.Key))
            {
                Console.WriteLine($" # {drink.Key} --> {drink.Value}");
            }
        }
    }
}
