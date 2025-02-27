public class Animal
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;

    }
    public virtual void makeSound()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }

}