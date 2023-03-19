using classDogHomework;
using System.Data;
using System.Reflection.Metadata;

Dog dog = new Dog("Nora", "Hasky", "black");

Console.WriteLine("Enter number");
string input = Console.ReadLine();

int number;

if(input == "1")
{
    dog.Eat();
}
else if(input == "2")
{
    dog.Play();
}
else if(input == "3")
{
    dog.ChaseTail();
}
else
{
    Console.WriteLine("Invalid input");
}
