using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private List<Fish> fishInPool;

        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            //this.Capacity = capacity;
            this.Size = size;

            this.fishInPool = new List<Fish>();
        }

        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int Size { get; }

        //???
        public void Add(Fish fish)
        {
            
            this.fishInPool.Add(fish);
            
        }

        public bool Remove(string name)
        {
            Fish fish = this.fishInPool.FirstOrDefault(f => f.Name == name);

            return this.fishInPool.Remove(fish);

        }

        public Fish FindFish(string name)
        {
            Fish fish = this.fishInPool.FirstOrDefault(f => f.Name == name);

            return fish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Aquarium Info:");
            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");
            foreach (var fish in fishInPool)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString();
        }
    }
}