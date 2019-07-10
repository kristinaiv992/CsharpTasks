namespace LinQ
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race DogRace { get; set; }

        public Dog(string name, string color, int age, Race dogsRaces)
        {
            Name = name;
            Color = color;
            Age = age;
            DogRace = dogsRaces;
        }

    }
}