using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] pokeInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

                string trainerName = pokeInfo[0];
                string pokemonName = pokeInfo[1];
                string pokemonElement = pokeInfo[2];
                int pokemonHealth = int.Parse(pokeInfo[3]);
                if (trainers.ContainsKey(trainerName))
                {
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    trainers[trainerName].Collection.Add(pokemon);

                }
                else
                {
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    Trainer trainer = new Trainer(trainerName, pokemon);
                    trainers.Add(trainerName, trainer);
                }



            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    bool elementExsist = false;

                    foreach (var pokemon in trainer.Value.Collection)
                    {
                        if (pokemon.Element == input)
                        {
                            elementExsist = true;
                        }
                    }

                    if (elementExsist)
                    {
                        trainer.Value.BadgeCounter++;
                    }
                    else
                    {
                        trainer.Value.RemoveTenHealth();
                    }

                    trainer.Value.CheckPokemonHealth();
                }

            }

            foreach (var tr in trainers.OrderByDescending(x => x.Value.BadgeCounter))
            {
                Console.WriteLine(tr.Value.ToString());
            }
        }
    }
}
