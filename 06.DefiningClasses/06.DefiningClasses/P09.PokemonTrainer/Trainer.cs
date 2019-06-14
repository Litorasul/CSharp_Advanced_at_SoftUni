using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09.PokemonTrainer
{
    class Trainer
    {
        public string Name { get; set; }
        public int BadgeCounter { get; set; }

        public List<Pokemon> Collection { get; set; }

        public Trainer(string name, Pokemon pokemon)
        {
            Name = name;
            BadgeCounter = 0;
            Collection = new List<Pokemon>();
            Collection.Add(pokemon);
        }

        public override string ToString()
        {
            return $"{Name} {BadgeCounter} {Collection.Count}";
        }

        public void CheckPokemonHealth()
        {
            if (Collection.Count > 0)
            {
                Collection = Collection.Where(x => x.Health > 0).ToList();
            }
        }

        public void RemoveTenHealth()
        {
            foreach (var pokemon in Collection)
            {
                pokemon.Health -= 10;
            }
        }

    }
}
