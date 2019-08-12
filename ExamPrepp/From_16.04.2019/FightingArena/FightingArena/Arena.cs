using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            gladiators = new List<Gladiator>();
        }

        public string  Name { get; set; }

        public int Count => this.gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiator = this.gladiators.FirstOrDefault(g => g.Name == name);

            this.gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiator = this.gladiators
                .OrderByDescending(g => g.GetStatPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator gladiator = this.gladiators
                .OrderByDescending(g => g.GetWeaponPower()).FirstOrDefault();

            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator gladiator = this.gladiators
                .OrderByDescending(g => g.GetTotalPower()).FirstOrDefault();

            return gladiator;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }
    }
}