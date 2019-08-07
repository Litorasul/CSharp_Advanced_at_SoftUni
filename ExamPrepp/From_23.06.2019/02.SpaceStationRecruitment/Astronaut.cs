namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        public string Name { get; private set; }

        public int Age { get; private set; }
        public string Country { get; private set; }

        public Astronaut(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public override string ToString()
        {
            string result = $"Astronaut: {Name}, {Age} ({Country})";
            return result;
        }
    }
}
