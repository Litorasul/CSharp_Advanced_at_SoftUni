using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private List<Astronaut> data;
        private int count;

        public string Name { get; private set; }
        public int Capacity { get; }

        public int Count => count;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Astronaut>(capacity);
            count = 0;
        }

        public void Add(Astronaut astronaut)
        {
            if (Count < Capacity)
            {
                data.Add(astronaut);
                count++;
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronaut = data.FirstOrDefault(a => a.Name == name);
            if (astronaut != null)
            {
                data.Remove(astronaut);
                count--;
                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut result = null;
            int age = 0;
            foreach (var astronaut in data)
            {
                if (astronaut.Age > age)
                {
                    result = astronaut;
                    age = astronaut.Age;
                }
            }

            return result;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = data.FirstOrDefault(a => a.Name == name);

            return astronaut;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var astronaut in data)
            {
                result.AppendLine(astronaut.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
