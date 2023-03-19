
namespace classDogHomework
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }



        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating now");
        }
        public void Play()
        {
            Console.WriteLine($"The {Color} dog is playing now");

        }
        public void ChaseTail()
        {
            Console.WriteLine($"The {Breed} is now chasing its tail.");
        }
    }
}







